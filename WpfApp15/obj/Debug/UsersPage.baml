   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5          WpfApp15.UsersPage   5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp15     5        N� Title$  	UsersPage��5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UsersGrd��5         AutoGenerateColumns .  $��3��6n   $��5��6�   $	��650��6�   $
��Left=�6�   ��6�   Z�    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *UserSurname+  5"      $ Имя��6%    62   �� *
UserName+  5#      $ Отчество��6%    67   �� *UserMiddleName+  5$      $ 
Логин��6%    64   �� *	UserLogin+  5%      $ Пароль��6%    65   �� *PasswordHash+  5&      $ Роль��6%    63   �� *
RoleName+5(      �� 5)   
   $��3��6   $��3��6$   $.��(Данные для заполнения��68   $��14(�6U   $��Center=�6c   $	��Top=�6�   ���	#FF4B1E1E6�   �� 5*   
   -   5         ��Name$ 
SurnameTbx��5+      $��1��5*      $��3��6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$#	 Введите фамилию��5,      $	��Top=�66   $	��340��6N   ���	#FF4E1010.��6�   5-      �� 5.   
   -   5        $ NameTbx��5/      $��2��5.      $��3��6   $	 Введите имя��50      $	��340��6/   ���	#FF4E1010$	��Top=�6R   .��6�   51      �� 52   
   -   5        $ MiddleNameTbx��53      $��3��52      $��3��6   $%	 Введите отчество��54      $	��Top=�63   $	��340��6K   ���	#FF4E1010.��6�   55      �� 56   
   -   5        $ LoginTbx��57      $��5��56      $��3��6   $	 
Логин��58      $	��Top=�6,   $	��340��6D   ���	#FF4E1010.��6�   59      G� 5:   
   -   5        
 G�Name$
 PasswordTbx��5;      $��6��5:      $��3��6#   $	 Пароль��5<      $	��Top=�6)   $	��340��6A   ���	#FF4E10105=      �� 5@   
   -   5         ��Name$ AddBtn��5@      $��2��66   $��6��6F   $	��130��6S   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $
��Left=�6�   $��Добавить��6�   6�   �� 5A   
   -   5        $ 	UpdateBtn��5A      $��2��6<   $��3��6L   $��6��6`   $	��130��6m   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Изменить��6�   6�   �� 5B   
   -	   5        $ 	DeleteBtn��5B      $��3��6<   $��6��6L   $	��130��6Y   ���	#FF8D5757���	#FF653030$��Bottom=�6�   $��Right=�6�   $��Удалить��6�   6�   �� 5C   
   -
   5         ��Name$ RoleCbx��5C       �� DisplayMemberPath$ RoleName��6$   $	 Выберите роль��6B   $��3��6q   $��4��6�   $	��300��6�   $	��Top=�6�   6�   5D      5E      