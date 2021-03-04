using SecurePasswordEncryptionRegistryManager.Tools;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace SecurePasswordEncryptionRegistryManager
{
    public partial class MainWindow : Window
    {
        private MyCrypto crypto;
        private IOTools ioTools;

        public MainWindow()
        {
            InitializeMyComponents();
            InitializeComponent();
            HideLockedItems();
            AddJobs();           
        }

        private void AddJobs()
        {
            Jobs.Items.Add("Export");
            Jobs.Items.Add("Import");
            Jobs.Items.Add("Delete");
            Jobs.SelectedIndex = 0;
        }

        private void InitializeMyComponents()
        {
            crypto = new MyCrypto();
            ioTools = new IOTools();          
        }

        private void GetPasswordBtnClick(object sender, RoutedEventArgs e)
        {
            string pwtext;
            if (ioTools.getAvailablePasswords().Contains(PasswordLabelTextBox.Text))
            {
                pwtext = crypto.Decrypt(MasterPasswordText.Password, ioTools.getEncryptedPassword(PasswordLabelTextBox.Text));
            }
            else
            {
                File.AppendAllLines(ioTools.dataPath, new string[] { $"{PasswordLabelTextBox.Text}:{crypto.Encrypt(MasterPasswordText.Password, crypto.GeneratePassword())}"});
                AvailablePasswords.Items.Add(PasswordLabelTextBox.Text);
                pwtext = crypto.Decrypt(MasterPasswordText.Password, ioTools.getEncryptedPassword(PasswordLabelTextBox.Text));
            }
            PasswordTextBox.Text = crypto.Obscure(pwtext, ShowCheckBox.IsChecked.GetValueOrDefault());
            Clipboard.SetText(pwtext);
        }

        private void UnlockBtnClick(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(ioTools.dataPath))
            {
                Directory.CreateDirectory(IOTools.dataPathRoot);
                File.WriteAllLines(ioTools.dataPath, new string[] { $"_Master:{crypto.Encrypt(MasterPasswordText.Password, MasterPasswordText.Password)}"});
            }
            
            if (crypto.Encrypt(MasterPasswordText.Password, MasterPasswordText.Password).Equals(ioTools.getEncryptedPassword("_Master")))
            {
                foreach (string entry in ioTools.getAvailablePasswords())
                {
                    AvailablePasswords.Items.Add(entry);
                }
                ShowUnlockedItems();
                BeginLockoutCountdown();
            }
        }

        private void JobRunner_Click(object sender, RoutedEventArgs e)
        {
            switch (Jobs.SelectedItem)
            {
                case "Delete":
                    ioTools.DeleteEntry(PasswordTextBox.Text);
                    break;
                case "Export":
                    ioTools.safeCopy(ioTools.dataPath, ioTools.desktopDataPath);
                    break;
                case "Import":
                    ioTools.safeCopy(ioTools.desktopDataPath, ioTools.dataPath);
                    foreach (string entry in ioTools.getAvailablePasswords())
                    {
                        AvailablePasswords.Items.Add(entry);
                    }
                    break;
            }
        }


        private void AvailablePasswords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PasswordLabelTextBox.Text = AvailablePasswords.SelectedValue.ToString();
        }

        private void Jobs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            JobRunner.Content = $"Run: {Jobs.SelectedValue}";
        }

        private void HideLockedItems()
        {
            UnlockBtn.Visibility = Visibility.Visible;
            MasterPasswordLabel.Visibility = Visibility.Visible;
            MasterPasswordText.Visibility = Visibility.Visible;

            PasswordLabelLabel.Visibility = Visibility.Hidden;
            AvailablePasswords.Visibility = Visibility.Hidden;
            PasswordLabelTextBox.Visibility = Visibility.Hidden;
            GetPasswordBtn.Visibility = Visibility.Hidden;
            PasswordLabel.Visibility = Visibility.Hidden;
            PasswordTextBox.Visibility = Visibility.Hidden;
            Jobs.Visibility = Visibility.Hidden;
            JobsLabel.Visibility = Visibility.Hidden;
            JobRunner.Visibility = Visibility.Hidden;
            ShowLabel.Visibility = Visibility.Hidden;
            ShowCheckBox.Visibility = Visibility.Hidden;
        }

        private void ShowUnlockedItems()
        {
            UnlockBtn.Visibility = Visibility.Hidden;
            MasterPasswordLabel.Visibility = Visibility.Hidden;
            MasterPasswordText.Visibility = Visibility.Hidden;

            PasswordLabelLabel.Visibility = Visibility.Visible;
            AvailablePasswords.Visibility = Visibility.Visible;
            PasswordLabelTextBox.Visibility = Visibility.Visible;
            GetPasswordBtn.Visibility = Visibility.Visible;
            PasswordLabel.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Visible;
            Jobs.Visibility = Visibility.Visible;
            JobsLabel.Visibility = Visibility.Visible;
            JobRunner.Visibility = Visibility.Visible;
            JobRunner.Content = $"Run: {Jobs.SelectedValue}";
            ShowLabel.Visibility = Visibility.Visible;
            ShowCheckBox.Visibility = Visibility.Visible;
        }

        private async Task BeginLockoutCountdown()
        {
            await Task.Delay(300000);
            MasterPasswordText.Password = "";
            this.HideLockedItems();
        }
    }
}
