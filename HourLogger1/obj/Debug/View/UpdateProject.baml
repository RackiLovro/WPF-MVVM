   M S B A M L   `   `   `  ����E  AHourLogger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HourLogger.ConvertersHourLogger.Converters  5   	   #    HourLogger.View.UpdateProject   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HourLogger.Converters     5   	   $	��200��5   	   $	��400��6     � 	Resources  5      ,  &HourLogger.Converters.ProjectConverter   projectConverter��%   &	          5	   
   6<   5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��25 �6   .+�5   
   �� $��Center=�6   $��Right=�6+   $��Project name:��6G   $��0��6_   $��0��6l   �� 5   
   -   5        $��projectName��5   m   $
��Left=�6   $��26��6-   $	��120��69   $��0��6�   $��1��6�   ��6E   ��  �� Path$
 Name� �� Mode$ OneWay=�6�   �� 5   
   -   5        $
��Save��5      $��2��6.   $��0��6;   ��5      �� $ UpdateCommand���5      `� 5       `� 	Converter# [  6   .1�5      �� $ Project�6   �� 5      $
 Text�6    �� ElementName$ projectName��6*   5      5       �� 5"   
   -   5        $��Cancel��5"      $��2��60   $��1��6=   5#      5$      