   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5          WpfApp15.DataPage   5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp15     5        N� Title$  DataPage��5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrd��5         AutoGenerateColumns .  $��2��6l   $��6��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$) #Фамилия сотрудника��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *UserSurname+  5!      $ 
Логин��6%    64   �� *	UserLogin+  5"      $ Пароль��6%    65   �� *PasswordHash+5$      �� 5%   
   $��2��6   $��3��6$   $.��(Данные для заполнения��68   $��14(�6U   $��Center=�6c   $��Center=�6�   ���	#FF4B1E1E6�   �� 5&   
   -   5         ��Name$ LoginTbx��5'      $��1��5&      $��2��6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Логин��5(      $	��Top=�6,   $	��340��6D   ���	#FF4E1010.��6h   5)      �� 5*   
   -   5        $ PasswordTbx��5+      $��2��5*      $��2��6   $	 Пароль��5,      $	��Top=�6)   $	��340��6A   ���	#FF4E1010.��6e   5-      �� 5/   
   -   5        
 ��Name$
 AddBtn��5/      $��2��6"   $��5��62   $	��130��6?   ���	#FF8D5757���	#FF653030$��Bottom=�6z   $
��Left=�6�   $��Добавить��6�   6�   �� 50   
   -   5        $
 	UpdateBtn��50      $��2��6$   $��3��64   $��5��6H   $	��130��6U   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Изменить��6�   6�   �� 51   
   -   5        $
 	DeleteBtn��51      $��3��6$   $��5��64   $	��130��6A   ���	#FF8D5757���	#FF653030$��Bottom=�6|   $��Right=�6�   $��Удалить��6�   6�   �� 52   
   -   5         ��Name$ 
SurnameCbx��52       �� DisplayMemberPath$ UserSurname��6'   $��2��6G   $��3��6W   6f   53      54      