   M S B A M L   `   `   `  ����C  ?Receipts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ReceiptsReceipts  5          Receipts.ScaleRecipePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Receipts     5        N� Title$  ScaleRecipePage��5	      .��5      � ���	#FFF9F6F6$��10q�6"    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��Select a recipe to scale:��6   $��0��64   $��10q�6A   �� 5   
   -   5         ��Name$ RecipeListBox��5      $��1��6)   $��10q�66   �� 5   
   $<��6Enter scale factor (e.g., 0.5 for half, 2 for double):��6   $��2��6Q   $��10q�6^   �� 5   
   -   5         ��Name$ ScaleFactorTextBox��5      $��2��6.   $��10q�6;   �� 5   
   -   5        $��Scale Recipe��5      $��3��6(   $��10,10,10,59q�65   6J   �� 5    
   -   5         ��Name$ 
BackButton��5       $��Button��6%   $
��Left=�66   $��619,273,0,0q�6Q   $��3��6f   $	��Top=�6s   $	��111��6�   6�   5!      5"      