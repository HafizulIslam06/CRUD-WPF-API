   M S B A M L   `   `   `  ����R  NPerky_Rabbit_Assessment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Perky_Rabbit_AssessmentPerky_Rabbit_Assessment  5   	   (    "Perky_Rabbit_Assessment.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Perky_Rabbit_Assessment     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��21* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$ lblName��5      $��Name :��6!   $
��Left=�62   $��	50,50,0,0q�6M   $	��Top=�6`   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��	97,54,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��120��6�   $��22��6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��	97,82,0,0q�6L   $	��Top=�6_   $	��120��6w   6�   &   System.Windows.Controls.DataGrid  5   
   <my-http://schemas.microsoft.com/wpf/2008/toolkit     5      -   5          Name$ 
dgCategory��5      $��286,82,53,53q�6'   $��2��6=      CanUserAddRows$
 True��5         AutoGenerateColumns$ False��5      ��5      �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Category Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ��  �� Path$ 
categoryId�  5      $
  Name��6%    64   �� $
 Name�4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Edit Action��6)      CellTemplate 5      �� 5      .R�5      �� -   5        .��5   9   Edit6?   5      5        5       $
 Delete Action��6)    5!      �� 5"      .R�5#      �� -   5        .��5#   ?   Delete6G   5$      5&      5(      �� 5)   
   -   5        $ btnLoad��5)      $��Load category��6"   $
��Left=�6:   $��
286,55,0,0q�6U   $	��Top=�6i   $��2��6�   $	��461��6�   6�   �� 5*   
   -   5        $ txtCategoryId��5*      $
��Left=�6)   $y�Hidden=�6D   $��	97,31,0,0q�6X   $
 Wrap=�6k   $��0��6   $	��Top=�6�   $	��120��6�   �� 5+   
   -	   5        $ 
lblMessage��5+      $�� ��6$   $
��Left=�6/   $y�Hidden=�6J   $��286,386,0,0q�6^   $	��Top=�6s   $	��461��6�   $��2��6�   5-      5.      