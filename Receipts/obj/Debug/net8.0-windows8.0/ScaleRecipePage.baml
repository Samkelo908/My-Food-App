   M S B A M L   `   `   `  ����C  ?Receipts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ReceiptsReceipts  5          Receipts.ScaleRecipePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Receipts     5        N� Title$  ScaleRecipePage��5	      .��5      � $��10q�6   ��5   
   �� 5       �� ImageSource$ /background4.jpg��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   $��79.04��6*    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��Select a recipe to scale:��6   $��0��64   $��10,10,553,10q�6A   ���	#FFF3EBEB$
��Bold"�6n   $��Italic$�6�   �� 5   
   -   5         ��Name$ RecipeListBox��5      $��1��6)   $��10,10,553,10q�66   �� 5   
   $<��6Enter scale factor (e.g., 0.5 for half, 2 for double):��6   $��364,10,58,10q�6Q   ���	#FFEAE3E36g   �� 5    
   -   5         ��Name$ ScaleFactorTextBox��5       $��1��6.   $��374,0,0,145q�6;   $
��Left=�6P   $	��128��6k   $��3��6w   �� 5#   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��	0,10,0,10q�6X   $	��440��6k   .+�5$      �� -   5        $��Scale Recipe��5$      $
��Bold"�6F   $��Italic$�6X   $��15(�6k   ���	#FFE40D0D$��10q�6�   $	��182��6�   �� 5%      -   5         ��Name$ 
BackButton��5%      $
��Back��6)   $
��Bold"�6Q   $��Italic$�6c   $��15(�6v   ���	#FF0922EF$��10q�6�   $	��109��6�   5&      5'      5(      