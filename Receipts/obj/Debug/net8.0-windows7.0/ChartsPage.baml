   M S B A M L   `   `   `  ����C  ?Receipts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ReceiptsReceipts  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          Receipts.ChartsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:Receipts     5      Dwpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� Title$  Charts Page��5       N� 
Background 5      �� 5   
    �� ImageSource$ /one.jpg��6   .��5
      � ��5   
   �� 5      $ /10.jpg��6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��10q�6%   .+�5      �� $��Select Food Groups:��6   $
��Bold"�63   $��0,0,0,10q�6E   �� 5      -   5         ��Name$ FoodGroupListBox��5       �� SelectionMode$ Multiple=�60   $	��200��6I   5      �� 5      -   5        $��
Show Chart��5      $��0,10,0,0q�6H   ���	#FF1426B7$
��Bold"�6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      5      �� 5!   
   $��1��6   $��10q�6%   .+�5"      �� $��Food Group Distribution��6   $
��Bold"�67   $��0,0,0,10q�6I   $��Center=�6[     LiveCharts.Wpf.PieChart  5#      -   5          Name$ FoodGroupPieChart��5#      $	��350��66   5$      5%      5&      