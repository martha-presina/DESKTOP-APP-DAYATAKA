   M S B A M L   `   `   `  ����D  @AppAsrama, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AppAsrama.ViewAppAsrama.View  5   	        AppAsrama.View.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AppAsrama.View     5   	     � Title$  Login��5   	   $	��720��6   $
��1280��6$    � Icon$ ../Image/DAYATAKA.png��61    � WindowStyle$
 None=�6N   .��5
      � ���	#FF182627 � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $	��720 �6   6+   �� 5      $��1* �6   6*    � ColumnDefinitions 5   
   �� 5      $��0* �6   6,   �� 5      $��1* �6   6,   �� 5      $	��300 �6   6-   �� 5      $��1* �6   6,   �� 5      $��0* �6   6,   .+�5   
   �� $��1��6   $��2��6"   $��0,100q�62   .+�5      �� $	��180��6   .+�5      �� $��../Image/DAYATAKA.png��6   $	��174��67   $	��174��6C   $��Center=�6P   5      �� 5      $	��180��6   .+�5      �� -   5         ��Name$ lblID��5      $��ID��6'   $��14(�64   ���	#FF02A852$��0,30,0,0q�6Y   �� 5      -   5         ��Name$ txtID��5      $��20��6)    �� TextWrapping$
 Wrap=�65   ���	#FFC5F1BE$��12(�6`   �� 5      -   5        $ lblPWD��5      $��PASSWORD��6(   $��14(�6;   ���	#FF02A852$��	0,20,30,0q�6`   �� 5      -   5        $ txtVisiblePWD��5      $��23��61   $��5,2,47,0q�6=   $��0,0,30,0q�6P   $
 Wrap=�6b   ���	#FFC5F1BE$��12(�6�   G� 5       -   5         G�Name$ txtPWD��5       $��23��6.   $��5,2,47,0q�6:   $��
0,-23,30,0q�6M   ���	#FFC5F1BE6x   �� 5!      $��23��6   $��23��6(   ���	#FFC5F1BE$��Right=�6D   $��	0,-23,3,0q�6`   �� 5"      -   5        $��ShowHide��5"   ,   $y�Hidden=�6   $��../Image/Icon/EYE.png��6<   $��20��6[   $��20��6g   $��	0,-23,4,0q�6r   $��Right=�6�   	 J� OpacityMask
	 �   �6  5#      �� 5$      $��50��6   .+�5%      �� -   5        
 ��Name$
 btnLogin��5%      $��Login��6+   $��35,10,35,10q�6;   $��30��6P   $��16(�6\   ���	#FF02A852���	#FFC5F1BE$��Georgia)�6�   5&      �� 5'      $��30��6   .+�5(      �� -   5        $ lblCopyright��5(      $ ��CopyRight : KOSAN SOFTWARE��6.   $��11(�6S   ���	#FF575757$��Center=�6x   $��Center=�6�   $
��Bold"�6�   5)      5*      �� 5+   
   $��1��6   $��1��6%   .+�5,      �� $	��166��6   $+��%/AppAsrama;component/Image/Border.png��6    $
��Left=�6O   $��Stretch=�6j   $
��Fill=�6�   $	��720��6�   5-      �� 5.   
   $��3��6   $��1��6%   .+�5/      �� $	��166��6   $+��%/AppAsrama;component/Image/Border.png��6    $��Right=�6O   $��Stretch=�6k   $
��Fill=�6�   $	��720��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�50      V� 51      .~�52      �� �� 53      �� 54       �� Angle$ 179.95Q�6*   T� 55      56      58      59      �� 5:   
   $��3��6   $��0��6%   ���	#FF182627.+�5;      �� -	   5        $
 btnExit��5;       � ToolTip$
 Exit��6&   $��x��65   $��30��6A   $��30��6L   $��15(�6X   ���	#FF830909���	#FFC5F1BE$��Georgia)�6�   $��Right=�6�   ���	#FF8309096�   �� 5<      -
   5        $
 btnMin��5<      $ Minimize��6%   $��-��68   $��30��6D   $��30��6O   $��30(�6[   ���	#FF182627���	#FFC5F1BE$��Georgia)�6�   $��Right=�6�   $��
0,-30,30,0q�6�   ���	#FF1826276�   5=      5>      5?      