   M S B A M L   `   `   `  ����B  >GUI_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GUI_WPFGUI_WPF  5          GUI_WPF.ReportsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:GUI_WPF     5        N� Title$  ReportsPage��5	       � 	Resources 5
         	CardStyle �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   
BlurRadius   ShadowDepth  SectionTitleStyle  ContentTextStyle��%�  &	        &	 7    &	 �    �� 5   
   " ��6"   .�5      ��  �@��CornerRadius$ 10��6-   �� 5       � ��
 �����6+   �� 5       � ��$ 15q�6'   �� 5       �@��Padding$ 20q�6(   �� 5       �@J�Effect 5        5      $ Black��6'   $ 5Q�65   $ 2Q�6D   5      5      �� 5   
   " ��6*   .�5      ��  � ��$ 18(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#2E8B576+   �� 5       � ��$ 0,0,0,10q�6'   5      �� 5   
   " ��6)   .�5      ��  � ��$ 14(�6)   �� 5       � ��
 �   �6+   �� 5        � ��$
 Wrap=�6-   �� 5!       � ��$ 0,0,0,10q�6'   5"      5#      .��5%      � ��5&   
   �� 5'       �� ImageSource$ NewFolder2/po.jpg��6   	 � RowDefinitions	 5)   
   �� 5*      $
��Auto �6   �� 5+      $��* �6   .+�5/   
   �� $��Tour Guide App Reports��6   $��40(�50      $
��Bold"�51      
�������$��Center=�53      $��10q�54      �� 57   
   $��1��6   $��Disabled=�6$   $
��Auto=�6M   .��58      (� 
 (� Stretch$
 Uniform=�6    (� StretchDirection$ DownOnly=�6(   $��10q�6D   .��59      ��  �� Orientation$ Vertical=�6   $��Center=�64   $	��700��6Q   .+�5;      �� #��[  6   ._�5<      �� .+�5=      �� $��About Our Services��6(   #��[ 6B   �� 5>      $c��]We guide you to explore breathtaking islands, luxurious stays, and unique dining experiences.��6(   #��[ 5?   (   5@      5A      �� 5D      #��[  6   ._�5E      �� .+�5F      �� $��Contact Information��6(   #��[ 6C   �� 5G      $��Phone: +94 789 147��6(   #��[ 6B   �� 5H      $!��Telegram: t.me/tourguideapp��6(   #��[ 6K   �� 5I      $)��#Facebook: facebook.com/tourguideapp��6(   #��[ 6S   5J      5K      �� 5N      #��[  6   ._�5O      �� .+�5P      �� $��Quick Links��6(   #��[ 6;   �� 5Q      $ 
Horizontal=�6)   $
��Left=�6B   .+�5R   "   �� $
��• ��6,   $��16(�66   $
��Bold"�6D   ���#2E8B576V   �� 5S   "   $��Top Islands��6,   #��[ 6?   5T      �� 5U      $ 
Horizontal=�6)   $
��Left=�6B   .+�5V   "   �� $
��• ��6,   $��16(�66   $
��Bold"�6D   ���#2E8B576V   �� 5W   "   $��Luxury Hotels��6,   #��[ 6A   5X      �� 5Y      $ 
Horizontal=�6)   $
��Left=�6B   .+�5Z   "   �� $
��• ��6,   $��16(�66   $
��Bold"�6D   ���#2E8B576V   �� 5[   "   $��Exciting Activities��6,   #��[ 6G   5\      5]      5^      5_      5`      5a      5b      5c      