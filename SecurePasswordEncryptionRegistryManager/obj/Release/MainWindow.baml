   M S B A M L   `   `   `  ���� b  ^SecurePasswordEncryptionRegistryManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:SecurePasswordEncryptionRegistryManager'SecurePasswordEncryptionRegistryManager  8    2SecurePasswordEncryptionRegistryManager.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Glocal5clr-namespace:SecurePasswordEncryptionRegistryManager       � Title$  	S.P.E.R.M��$��236.675��$	��475��.��� 
���   � � ColumnDefinitions �� $��7* ��� $
��699* �.+��� -   $��MasterPasswordLabel��$��Master Password:��$
��Left=�$��	13,19,0,0q�$	��Top=�$
��Bold"�$��Consolas)�$��14(�$��1��
�������G� -   $��MasterPasswordText��$��1��$
��Left=�$��
146,23,0,0q�$	��Top=�$	��125��
��������� -   $��	UnlockBtn��$��Unlock��$��1��$
��Left=�$��
113,58,0,0q�$	��Top=�$��75���� -   $��PasswordLabelLabel��$��Password Label:��$
��Left=�$��	10,32,0,0q�$	��Top=�$
��Bold"�$��Consolas)�$��14(�$��1��
��������� -   $��AvailablePasswords��$��1��$
��Left=�$��
168,28,0,0q�$	��Top=�$	��120�� J� RenderTransformOrigin$ 0.502,1.791&��� -   $��PasswordLabelTextBox��$
��Left=�$��23��$��	15,63,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��125��$��1��
�������
��������� -   $��GetPasswordBtn��$��Get Password��$
��Left=�$��
168,63,0,0q�$	��Top=�$	��103��$��1���� -   $��PasswordLabel��$��	Password:��$
��Left=�$��
11,102,0,0q�$	��Top=�$
��Bold"�$��Consolas)�$��16(�$��1��
��������� -	   $��PasswordTextBox��$
��Left=�$��26��$��100,102,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��156��$��1��
���   �
��� ����� -
   $��	ShowLabel��$
��Show��$��1��$
��Left=�$��
256,93,0,0q�$	��Top=�$
��Bold"�$��Consolas)�$��16(�
��������� -   $��ShowCheckBox��$��CheckBox��$��1��$
��Left=�$��261,113,0,0q�$	��Top=� d� 	IsChecked$ FalseY��� -   $��	JobsLabel��$��Jobs:��$��1��$
��Left=�$��
15,139,0,0q�$	��Top=�$
��Bold"�$��Consolas)�$��16(�
��������� -   $
��Jobs��$��1��$
��Left=�$��
77,143,0,0q�$	��Top=�$	��120��$
��Bold"�$��Consolas)�$��16(��� -   $��	JobRunner��$�� ��$��1��$
��Left=�$��219,145,0,0q�$	��Top=�$��75���� $��22(�$��1��$��310,19,44,110q�$��Consolas)��� 
���  ��.�S �� 
���2�2�.�ecure�� $��22(�$��1��$��310,44,0,91q�$��Consolas)��� 
���  ��.�P �� 
���2�2�.�	assword�� $��22(�$��1��$��310,69,-2,71q�$��Consolas)��� 
���  ��.�E �� 
���2�2�.�	ncryption�� $��22(�$��1��$��310,94,10,41q�$��Consolas)��� 
���  ��.�R �� 
���2�2�.�egisty�� $��22(�$��1��$��310,119,10,16q�$��Consolas)��� 
���  ��.�M �� 
���2�2�.�anager