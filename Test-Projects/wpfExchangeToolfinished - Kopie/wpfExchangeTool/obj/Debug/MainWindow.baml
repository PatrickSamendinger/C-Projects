   M S B A M L   `   `   `  ����J  FwpfExchangeTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:wpfExchangeToolwpfExchangeTool  5   	        wpfExchangeTool.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:wpfExchangeTool     5   	   -   5          �Name$  wpfMain��5   	    � Title$ mars services��5   	   $	��250��6   $	��400��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   $��Calibri)�6s   $��14(�6�    � WindowStyle$
 None=�6�    � AllowsTransparency . 
������ $y�Visible=�6�   .��5
      �� 
���   �$��2q�6!    �� CornerRadius$ 8��65   
�������._�5   
   � $��2q�6   .+�5      � $��Stretch=�6   $��Stretch=�63    � RowDefinitions 5      �� 5      $	��50* �6$   63   �� 5      $	��50* �6$   �� 5      $	��50* �6$   �� 5      $	��50* �6$    � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      .+�5      �� -   5        	 ��Name$	 BtnShow��5   A      CustomButton#���   6   $��Infos anzeigen��6R   $
��Left=�6k   $��
10,18,0,18q�6�   $��Center=�6�   $	��125��6�   $��25��6�   $��1��6�   $��16(�6�   6�   �� 5      -   5        
 ��Name$
 LstBox��5      $��1��6*   $��Stretch=�6:   $��Stretch=�6Z   $��10,10,10,10q�6v   $��1��6�   ���	#FF0C0C0C$��16(�6�   �� 5      -   5        $��per Email senden?��5      $��1��67   $��Right=�6G   $��
0,21,10,21q�6c   $��2��6y   $��Center=�6�   ���	#FF0C0C0C$��16(�6�   �� 5      -   5         ��Name$ txtMail��5      $
��Left=�6,   $��
10,18,0,18q�6G   $��25��6[   $��3��6h    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $��Center=�6�   $	��125��6�   $��0��6�    J� OpacityMask
 �   ����	#FF0C0C0C$y�Hidden=�6�   $��12(�6  �� 5      -   5        $	 	btnSenden��5   A   #���   6   $��
0,18,10,18q�6T   $��Senden��6h   $��1��6y   $��Right=�6�   $��3��6�   $��Center=�6�   $��25��6�   $	��125��6�   ���	#FF0C0C0C
 �   �$��16(�6  $
��Bold"�6   $y�Hidden=�62  6F  �� 5      $
��Left=�6   $��10,5,0,0q�67   $
��Wrap=�6I   $
��mars��6]   $	��Top=�6i   $
��Bold"�6�   $��24(�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          
BlurRadius$ 3Q�6+      ShadowDepth$ 3Q�6:   5"      �� 5#      $
��Left=�6   $��65,5,0,0q�67   $
��Wrap=�6I   $��services��6]   $	��Top=�6m   $��24(�6�   $
��Bold"�6�   ���	#FFF00000 5$        5%      $ 3Q�6+   $ 3Q�6:   5'      �� 5(      -   5        #���   5(      $��Close��6@   $��0��6P   $��1��6]   $��Right=�6m   $��	0,10,10,0q�6�   $	��Top=�6�   $	��125��6�   $��25��6�   $��16(�6�   $
��Bold"�6�   5)      �� 5*      -   5         ��Name$ lblMail��5*      $$��Bitte Email-Adresse eintragen:��6%   $
��Left=�6N   $��	0,172,0,0q�6i   $	��Top=�6|   $��12(�6�   {�.  $y�Hidden=�6�   5+      5,      5-      