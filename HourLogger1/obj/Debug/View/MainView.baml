   M S B A M L   `   `   `  ����E  AHourLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HourLogger.ConvertersHourLogger.Converters  5   	       HourLogger.View.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5local#clr-namespace:HourLogger.Converters     5   	     � Title$  Modify Project��5   	   $	��485��6    $	��525��6-    � 	Resources 5      ,  &HourLogger.Converters.ProjectConverter   projectConverter��%   &	          5   
   6<   5      .��5
      � $��0,0,0,20q�6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��25 �6   �� 5      �� 5      �� 5      �� 5      $��25 �6   .+�5   
   �� -   5        $��activityList��5      $��3��6'   $��0��64   $��3��6D   $��4��6U   ��6i   ��  �� ElementName$ projectList�� �� Path$ SelectedItem.Acitvities� �� View 5      �� 5      -   5        grdActivity��.P�5      ��  �� Width$
 Auto��6%   $��Description��62    �� DisplayMemberBinding 6G   �� *Description+�� 5      $
 Auto��6%   $��Duration��62    6D   �� *
Duration+�� 5      $
 Auto��6%   $
��Date��62    6@   �� *
StringDate+�� 5       $
 Auto��6%   $��
Department��62    6F   �� *
Department+5!      5#      �� 5%   
   -   5        $��projectList��5%      $��0��6&   $��0��63   $��2��6C   $��4��6T   ��6h   �� *
Projects+ 5&      �� 5'      -   5        
grdProject��.P�5(      �� $��Project Name��6%    6;   �� *Name+5)      5+      �� 5-   
   -   5        $��
projectAdd��5-   <   $	��Add��6   $��2��6   $��0��6,   ��5.      �� $ 
AddProject��� 50   
   -   5        $��projectUpdate��50   @   $��Update��6   $��2��6"   $��1��60   ��51      �� $ UpdateProject���52      �� $ projectList��$ SelectedItem��� 54   
   -   5        $��projectDelete��54   ?   $��Delete��6   $��2��6"   $��2��6/   ��55      �� $ DeleteCommand���56      �� $ projectList��$ SelectedItem��� 58   
   -   5        $��activityAdd��58   <   $	��Add��6   $��6��6   $��0��6,   ��59      �� $ AddActivity���5:      �� $ projectList��$ SelectedItem��� 5<   
   -	   5        $��activityUpdate��5<   @   $��Update��6   $��6��6"   $��1��60   ��5=      �� $ UpdateActivity���5>      �� $ activityList��$ SelectedItem��� 5@   
   -
   5        $��activityDelete��5@   ?   $��Delete��6   $��6��6"   $��2��6/   ��5A      �� $ DeleteActivity���5B      �� $ activityList��$ SelectedItem�5D      5E      