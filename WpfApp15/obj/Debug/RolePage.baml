   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5          WpfApp15.RolePage   5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp15     5        N� Title$  RolePage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ RoleGrd��5         AutoGenerateColumns .  $��2��6l   $��6��6�   ��6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название роли��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
RoleName+5"      �� 5#   
   $��2��6   $��3��6$   $.��(Данные для заполнения��68   $��14(�6U   $��Center=�6c   $��Center=�6�   ���	#FF4B1E1E6�   �� 5$   
   -   5         ��Name$ RoleTbx��5%   	   $��1��5$      $��2��6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$.	 (Введите название роли��5&   	   $	��Top=�6@   $	��340��6X   ���	#FF4E1010.��6�   5'      �� 5(   
   -   5        
 ��Name$
 AddBtn��5(      $��2��66   $��5��6F   $	��130��6S   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $
��Left=�6�   $��Добавить��6�   6�   �� 5)   
   -   5        $
 	UpdateBtn��5)      $��2��6<   $��3��6L   $��5��6`   $	��130��6m   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Изменить��6�   6�   �� 5*   
   -   5        $
 	DeleteBtn��5*      $��3��6<   $��5��6L   $	��130��6Y   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Right=�6�   $��Удалить��6�   6�   5+      5,      