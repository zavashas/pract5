   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5           WpfApp15.ManufacturersPage   5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp15     5        N� Title$  ManufacturersPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SkladGrd��5         AutoGenerateColumns .  $��2��6n   $��0��6�   $��5��6�   ��6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Производитель��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *ManufacturerName+  5      $ Страна��6%    65   �� *	Country+5!      �� 5"   
   -   5         ��Name$ ManufacturerNameTbx��5"      $��2��6g   $��1��6w   $	��Top=�6�   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$1	 +Название производителя��6�   6�   �� 5#   
   -   5        $ 
CountryTbx��5#      $��2��6U   $��2��6e   $	��Top=�6r   $	 Страна��6�   6�   �� 5%   
   -   5        
 ��Name$
 AddBtn��5%      $��2��66   $��5��6F   $	��130��6S   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $
��Left=�6�   $��Добавить��6�   6�   �� 5&   
   -   5        $
 	UpdateBtn��5&      $��2��6<   $��3��6L   $��5��6`   $	��130��6m   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Изменить��6�   6�   �� 5'   
   -   5        $
 	DeleteBtn��5'      $��3��6<   $��5��6L   $	��130��6Y   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Right=�6�   $��Удалить��6�   6�   �� 5)   
   -   5        $
 	ImportBtn��5)   B   $��0��6   $��2��6!   $��5��65   $	��390��6V   ���	#FF8D5757���	#FF653030$-��'Импортировать данные��6�   $��Bottom=�6�   6�   5+      5,      