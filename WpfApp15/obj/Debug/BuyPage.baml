   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5          WpfApp15.BuyPage   5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp15     5        N� Title$  BuyPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5    
   �� -   5         ��Name$ OrderIdTextBox��5       $��0��6*   $��1��67   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Номер заказа��6G   �� 5"   
   -   5         ��Name$ FurnitureComboBox��5"      $��1��6.   $��1��6;   $ Мебель��6K   �� 5$   
   -   5        $ FurnitureQuantityTextBox��5$      $��2��64   $��1��6A   $' !Количество мебели��6Q   �� 5&   
   -   5        $ ServicesComboBox��5&      $��3��6-   $��1��6:   $ Услуги��6J   �� 5(   
   -   5        $ ServiceQuantityTextBox��5(      $��4��62   $��1��6?   $% Количество услуг��6O   (  "System.Windows.Controls.DatePicker  5*   
   -   5          Name$ OrderDatePicker��5*      $��5��6.   $��1��6;   $ Дата заказа��6K   �� 5,   
   $!��Добавить заказ��6   $��6��6*   $
��Left=�69   �� 5-   
   $��Выгрузить чек��6   $��6��6)   $��Right=�68   �� 51   
   -   5        $ UserComboBox��51      $��0��6)   $��3��66   $��10q�6F   $ Пользователь��6R   �� 53   
   -   5        $ SumMoneyClientTextBox��53      $��1��61   $��3��6>   $��10q�6N   $ Сумма клиента��6Z   �� 55   
   -	   5        $ PriceServiceTextBox��55      $��2��6/   $��3��6<   $��10q�6L   $ Цена услуги��6X    �� 
IsReadOnly . 6�   �� 57   
   -
   5        $ PriceFurnitureTextBox��57      $��3��61   $��3��6>   $��10q�6N   $ Цена мебели��6Z    . 6�   �� 59   
   -   5        $ ChangeTextBox��59      $��4��6)   $��3��66   $��10q�6F   $ 
Сдача��6R    . 6y   �� 5;   
   -   5        $ TotalPriceTextBox��5;      $��5��6-   $��3��6:   $��10q�6J   $( "Общая сумма заказа��6V    . 6�   �� 5=   
   $��Вычислить��6   $��6��6%   $��0��62   $��10q�6B   &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ ViewGrd��5>      $��5��6$   	   AutoGenerateColumns	 . ��6P   �� 5?      5A      