   M S B A M L   `   `   `  ����b  ^SecurePasswordEncryptionRegistryManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:SecurePasswordEncryptionRegistryManager'SecurePasswordEncryptionRegistryManager  5   	   8    2SecurePasswordEncryptionRegistryManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:SecurePasswordEncryptionRegistryManager     5   	     � Title$  	S.P.E.R.M��5   	   $��208.19��6   $	��475��6+   .��5
      � 
���   � � ColumnDefinitions 5   
   �� 5      $��7* �6   �� 5      $
��699* �6   .+�5   
   �� -   5        $��MasterPasswordLabel��5      $��Master Password:��6+   $
��Left=�6F   $��	13,19,0,0q�6a   $	��Top=�6t   $
��Bold"�6�   $��Consolas)�6�   $��14(�6�   $��1��6�   
�������6�   G� 5   
   -   5        $��MasterPasswordText��5      $��1��60   $
��Left=�6@   $��
146,23,0,0q�6[   $	��Top=�6o   $	��125��6�   
�������6�   �� 5   
   -   5        $��	UnlockBtn��5      $��Unlock��6"   $��1��63   $
��Left=�6C   $��
113,58,0,0q�6^   $	��Top=�6r   $��75��6�   6�   �� 5   
   -   5        $��PasswordLabelLabel��5      $��Password Label:��6*   $
��Left=�6D   $��	10,32,0,0q�6_   $	��Top=�6r   $
��Bold"�6�   $��Consolas)�6�   $��14(�6�   $��1��6�   
�������6�   �� 5   
   -   5        $��AvailablePasswords��5      $��1��6-   $
��Left=�6=   $��
168,28,0,0q�6X   $	��Top=�6l   $	��120��6�    J� RenderTransformOrigin$ 0.502,1.791&�6�   �� 5   
   -   5        $��PasswordLabelTextBox��5      $
��Left=�6.   $��23��6I   $��	15,63,0,0q�6U    �� TextWrapping$
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��125��6�   $��1��6�   
�������
�������6�   �� 5   
   -   5        $��GetPasswordBtn��5      $��Get Password��6'   $
��Left=�6>   $��
168,63,0,0q�6Y   $	��Top=�6m   $	��103��6�   $��1��6�   �� 5   
   -   5        $��PasswordLabel��5      $��	Password:��6%   $
��Left=�69   $��
11,102,0,0q�6T   $	��Top=�6h   $
��Bold"�6�   $��Consolas)�6�   $��16(�6�   $��1��6�   
�������6�   �� 5   
   -	   5        $��PasswordTextBox��5      $
��Left=�6)   $��26��6D   $��100,102,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��194��6�   $��1��6�   
���   �
��� ���6�   �� 5   
   $��22(�6   $��1��6"   $��310,19,44,110q�62   $��Consolas)�6I   �� 5      
���  ��.�6#   S6&    �� 5       
���2�2�.�6)   ecure60   5!      �� 5"   
   $��22(�6   $��1��6"   $��310,44,0,91q�62   $��Consolas)�6G   �� 5#      
���  ��.�6#   P6&    �� 5$      
���2�2�.�6)   	assword62   5%      �� 5&   
   $��22(�6   $��1��6"   $��310,69,-2,71q�62   $��Consolas)�6H   �� 5'      
���  ��.�6#   E6&    �� 5(      
���2�2�.�6)   	ncryption64   5)      �� 5*   
   $��22(�6   $��1��6"   $��310,94,10,41q�62   $��Consolas)�6H   �� 5+      
���  ��.�6#   R6&    �� 5,      
���2�2�.�6)   egisty61   5-      �� 5.   
   $��22(�6   $��1��6"   $��310,119,10,16q�62   $��Consolas)�6I   �� 5/      
���  ��.�6#   M6&    �� 50      
���2�2�.�6)   anager61   51      55      56      