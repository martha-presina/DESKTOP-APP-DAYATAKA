   M S B A M L   `   `   `  ����D  @AppAsrama, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AppAsrama	AppAsrama  5          AppAsrama.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:AppAsrama     5        �� 	Resources  5         
sbShowMenu �� TargetProperty t� From	 t� To g� DecelerationRatio g� Duration  
sbHideMenu  spSlideLeft �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value :� RoutedEvent  	MenuLabel&   System.Windows.Media.TextOptions��%w  &	        &	 t     &	 �     &	 !    �� 5   
   .��5	      t� $ Opacity�6!   $ 0X�6E   $ 1X�6N   $ .9Q�6U   $ 0:0:1D�6l   5
      �� 5   
   .��5      t� $ Opacity�6!   $ 1X�6E   $ 0X�6N   $ .9Q�6U   $ 0:0:1D�6l   5      �� 5   
   " ��6$    5      P� 5       �@J�IsMouseOver	 . . �5      �� 
 � ��
 � � �63   5      :� 5      $ 
MouseEnter��6   [�5      �� 5      .��5      �� .��5       t� $ Margin�63   $ 
-150,0,0,0X�6V   $ 0,0,0,0X�6h   $ .9Q�6u   $ 0:0:0.8D�6�   5      5      5      :� 5       $ 
MouseLeave��6   [�5!      �� 5"      .��5#      �� .��5$   "   t� $ Margin�65   $ 0,0,0,0X�6X   $ 
-150,0,0,0X�6g   $ .9Q�6w   $ 0:0:0.5D�6�   5%      5&      5(      5*      �� 5,   
   " ��6"   .�5-      �� 
 � ��$ 14(�6)   �� 5.      
 � ��$ 40,0,0,0q�6(   �� 5/      
 � �� �	#FFACB5B96+   �� 50      
 �@ TextFormattingMode$ Display=�6?   �� 51      
 �@ TextRenderingMode$
 Auto=�6>    53      P� 54       �@J�IsMouseOver	 . . �55      �� 
 � �� �	#FF40B86663   �� 56      
 �@�Cursor$
 Hand��6/   �� 57      
 � ��$
 Bold"�63   58      P� 59       �@J�IsMouseOver	 .  . �5:      �� 
 � ��
 �����63   5;      5=      5>      5?      