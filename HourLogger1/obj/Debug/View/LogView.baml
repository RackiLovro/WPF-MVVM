   M S B A M L   `   `   `  ����E  AHourLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HourLogger.ViewHourLogger.View  5   	       HourLogger.View.LogView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HourLogger.View     5   	     � Title$
  Main��5   	   $	��400��6   $	��400��6#   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��25 �6   �� 5      �� 5      $��25 �6   �� 5      �� 5      $��25 �6   .+�5   
   �� $��Center=�6   $��Right=�62   $��0��5      $��0��6    $��Logged in as:��6-   �� 5   
   $��Center=�6   $
��Left=�62   $��1��5      $��0��6    ��6-   �� *
Username+�� 5   
   $��Center=�6   $��Right=�62   $��2��5       $��0��6    $��Department:��6-   �� 5!   
   $��Center=�6   $
��Left=�62   $��3��5"      $��0��6    ��6-   �� *
Department+�� 5$   
   $��Center=�6   $��Right=�62   $��0��5%      $��1��6    $��Member since:��6-   �� 5&   
   $��Center=�6   $
��Left=�62   $��1��5'      $��1��6    ��6-   �� *Date+�� 5)   
    �� DisplayMemberPath$ Username��6O   $��2��6l   $��2��6|    �� SelectedItem 6   �� *User+��61   �� *Users+6|   �� 5*   
   -   5        $��departmentList��5*      $
 Name��6N   $��2��6g   $��4��6w   ��6*   �� *Departments+6w   �� 5,   
   $
��User��6   $��2��6   $��1��6,   �� 5-   
   $��
Department��6   $��4��6%   $��1��62   �� 5/   
   $��Manage��6   $��0��51      $��6��6!   ��50      ��  �� Path$ Manage�51   !   �� 53   
   $��Switch��6   $��1��55      $��1��6!   $��6��65   ��53   "   �� $ SwitchDepartment���54      ��  �� ElementName$ departmentList��$ SelectedItem�55   5   �� 57   
   $��Generate Repot��6   $��2��58      $��2��6!   $��6��65   ��59      �� $ Generate�5:      5;      