   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5   	       WpfApp15.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp15     5   	     � Title$   Администратор��5   	   $	��650��6   $
��1000��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ RoleBtn��5      $	��140��68   ���	#FF8D5757$��Роли��6[   ���	#FF653030$	��Top=�6�   $
��Left=�6�   6�   �� 5   
   -   5        $ UsersBtn��5   !   $��1��6   $	��140��6J   ���	#FF8D5757���	#FF653030$��Сотрудники��6�   $	��Top=�6�   $��Center=�6�   6�   �� 5   
   -   5        $ CategoryBtn��5      $��2��6@   ���	#FF8D5757���	#FF653030$��Категории��6   $	��Top=�6�   6�   �� 5   
   -   5        $ ManufacturersBtn��5      $��3��6J   ���	#FF8D5757���	#FF653030$ ��Производители��6�   $	��Top=�6�   6�   �� 5    
   -   5        $ 
ServiceBtn��5    !   $��4��6   ���	#FF8D5757���	#FF653030$��Услуги��6~   $	��Top=�6�   6�   �� 5!   
   -   5        $ DiscountsBtn��5!   !   $��5��6   ���	#FF8D5757���	#FF653030$��Скидки��6�   $	��Top=�6�   6�   �� 5#   
   -   5        $ BackBtn��5#   !   $��6��6   ���	#FF8D5757���	#FF653030$��
Выход��6y   $	��Top=�6�   6�    � 5%   
   -   5          �Name$ 	PageFrame��5%      $��0��6#   $��7��63   $��1��6G   $��6��6T     � NavigationUIVisibility$ Hidden=�6e   6�   5&      5'      