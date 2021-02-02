using SecurePasswordEncryptionRegistryManager.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;

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
        }

        private void InitializeMyComponents()
        {
            crypto = new MyCrypto();
            ioTools = new IOTools();
        }

        private void GetPasswordBtnClick(object sender, RoutedEventArgs e)
        {
            if (ioTools.getAvailablePasswords().Contains(PasswordLabelTextBox.Text))
            {
                PasswordTextBox.Text = crypto.Decrypt(MasterPasswordText.Password, ioTools.getEncryptedPassword(PasswordLabelTextBox.Text));
            }
            else
            {
                File.AppendAllLines(ioTools.dataPath, new string[] { $"{PasswordLabelTextBox.Text}:{crypto.Encrypt(MasterPasswordText.Password, crypto.GeneratePassword())}"});
                AvailablePasswords.Items.Add(PasswordLabelTextBox.Text);
                PasswordTextBox.Text = crypto.Decrypt(MasterPasswordText.Password, ioTools.getEncryptedPassword(PasswordLabelTextBox.Text));
            }
            System.Windows.Clipboard.SetText(PasswordTextBox.Text);


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
            }
            
        }

        private void AvailablePasswords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PasswordLabelTextBox.Text = AvailablePasswords.SelectedValue.ToString();
        }

        private void HideLockedItems()
        {
            PasswordLabelLabel.Visibility = Visibility.Hidden;
            AvailablePasswords.Visibility = Visibility.Hidden;
            PasswordLabelTextBox.Visibility = Visibility.Hidden;
            GetPasswordBtn.Visibility = Visibility.Hidden;
            PasswordLabel.Visibility = Visibility.Hidden;
            PasswordTextBox.Visibility = Visibility.Hidden;
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
        }
    }
}
