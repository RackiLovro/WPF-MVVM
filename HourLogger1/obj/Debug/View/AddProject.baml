   M S B A M L   `   `   `  ����E  AHourLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HourLogger.ViewHourLogger.View  5   	        HourLogger.View.AddProject   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HourLogger.View     5   	     � Title$  
AddProject��5   	   $	��200��6   $	��400��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��25 �6   .+�5   
   �� $��Center=�6   $��Right=�6+   $��Project name:��6G   $��0��6_   $��0��6l   �� 5   
   -   5        $��projectName��5   E   $
��Left=�6   $��26��6-   $	��120��69   $��0��6X   $��1��6e   �� 5   
   -   5        $
��Save��5      $��1��6.   $��0��6;   ��5      ��  �� Path$ 
AddCommand���5      ��  �� ElementName$ projectName��$
 Text��� 5   
   -   5        $��Cancel��5      $��1��60   $��1��6=   5      5      