   M S B A M L   `   `   `  ����  
HourLogger    HourLogger.UpdateActivity   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Ažuriraj aktivnost��5   	   $	��450��6$   $	��800��61   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Center=�6   $��Center=�64   $��0��6V   $��0��6c   $��Odaberi projekt��6s   �� 5   
   -   5        $��activityProject��5      $��0��6J   $��1��6Z   5      �� 5   
   $��Center=�6   $��Center=�64   $��0��6V   $��1��6c   $��Odaberi aktivnost��6s   �� 5   
   -   5        $��activityDescription��5      $��1��6O   $��1��6_   5      �� 5   
   $��Center=�6   $��Center=�64   $��0��6V   $��2��6c   $��Promijeni opis aktivnosti��6s   $��2��6�   �� 5   
   -   5        $��updateDescription��5       �� TextWrapping$
 Wrap=�6+   $��Ažuriraj aktivnost��6?   $��1��6Y   $��2��6f   $��2��6v   (  "System.Windows.Controls.DatePicker  5!   
   -   5        $��
updateDate��5!      $��2��6'   $��0��64   $��2��6D   �� 5"   
   $��Center=�6   $��Center=�64   $��1��6V   $��2��6f   .��5#      �� $��WrapWithOverflow=�6    �� TextAlignment$ Center=�68   *(Promijeni broj odrađenih sati ili datum5%      5&      �� 5'   
   -   5        $��updateDuration��5'      $��1��6(   $��3��68   .@�5(      �� $��1��6   6(   �� 5)      $��2��6   6(   �� 5*      $��3��6   6(   �� 5+      $��4��6   6(   �� 5,      $��5��6   6(   �� 5-      $��6��6   6(   �� 5.      $��7��6   6(   �� 5/      $��8��6   6(   �� 50      $��9��6   6(   �� 51      $��10��6   6)   �� 52      $��11��6   6)   �� 53      $��12��6   6)   54      �� 56   
   -   5        
���  ��$��PONIŠTI��56   0   $��2��6B   $��3��6R   $��2��6_   �� 58   
   -   5        
��� � �$��AŽURIRAJ AKTIVNOST��58   3   $��2��6P   $��2��6`   �� 5:   
   -   5        
����  �$��OBRIŠI AKTIVNOST��5:   2   $��3��6M   $��2��6]   5;      5<      