   M S B A M L   `   `   `  ����X  TDrivingSchoolManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:DrivingSchoolManagementSystem.Views#DrivingSchoolManagementSystem.Views  5      8    2DrivingSchoolManagementSystem.Views.ControlVehicle   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:DrivingSchoolManagementSystem.Views     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5
        MaterialDesignFont#��[ 5      ���	#FF3B3B51.��5      �   � ColumnDefinitions  5   
   �� 5      $	��300 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   � -   5         �Name$ VehicleSearchView��5      $��0��6*   $��1��6:   $��0��6N   
�������.+�5      �� $��Search Vehicles By :��6   $
��Left=�63   $��37��6N   $��	10,10,0,0q�6Z    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��290��6�   ���	#DD080D21$
��Bold"�6�   $��16(�6�    J� RenderTransformOrigin$ 0.496,0.236&�6�   ��6�   Z� 6�   �� 5      $
��Left=�6   $��	10,47,0,0q�62   $	��Top=�6E   $	��280��6]   $ 0.509,-0.74&�6i   $��32��6�   ���	#890D10556�   �� 5      $
��Left=�6   $��31��61   $��	10,84,0,0q�6=   $
 Wrap=�6P   $��TextBox��6d   $	��Top=�6s   $	��280��6�   $ 0.491,-0.345&�6�   ���	#890D10556�   �� 5      $��Find Car��6   $
��Left=�6)   $��10,120,0,-2q�6D   $	��Top=�6Y   $	��280��6q   ���	#FF22537A$��20(�6�   5      � 5   
   -   5        $ VehiclesListView��5      $��0��6)   $��1��69   
�������$��0,0,1,0q�6Y   .+�5       )  #MaterialDesignThemes.Wpf.DialogHost  $��0,5,0,0q�6(      DialogContent 5!      �� 5"      $��16q�6!   .+�5$      �� -   5         ��Name$ FruitTextBox��5$   Q   $��0 8 0 0q�6"   $��Stretch=�63   6Q   �� 5%       �� Orientation$ 
Horizontal=�6%   $��Right=�6>   .+�5&      ��   MaterialDesignFlatButton#��[ 6%    �� 	IsDefault . $��0 8 8 0q�6h   $2��,materialDesign:DialogHost.CloseDialogCommand��6y   ��5'   "   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5(   5   ��6&   3system&clr-namespace:System;assembly=mscorlib  65   True��5*   '   .��5+   ;   ACCEPT5-      �� 5/      #��[ 6%   	 �� IsCancel	 . $��0 8 8 0q�6g   $2��,materialDesign:DialogHost.CloseDialogCommand��6x   ��50   "   1&clr-namespace:System;assembly=mscorlibSystem 51   5   ��6&   3system&clr-namespace:System;assembly=mscorlib  65   	False��53   '   .��54   ;   CANCEL56      58      59      .��5<      �   5=      �� 5>      $	��23* �6+   �� 5?      $
��277* �6+    5A      �� 5B      $��* �6(   �� 5C      $
��Auto �6(   .+�5O      (  "MaterialDesignThemes.Wpf.ColorZone  
   Mode$
 
PrimaryMid=�6/   $��1��6A     MaterialDesignShadowDepth5 J� Effect# �  6N   ���	#FF22537A$��2��6�   .��5P      �� $��16q�6$   $��18(�60   $��Segoe UI Historic)�6>   
Vehicles6h   5Q      �� 5S       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6      OpenDialogCommand#��Z 5T      $��Bottom=�5U      $��Right=�5V      $��0��5W      $��	0,0,28,36q�5X      ���	#FF532C66���	#FF532C66$��1��6_   $��2��6o   .��5Y      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$
 Plus=�62   $��22��6>   $��22��6J   5Z      5[      5]      5^      � 5`   
   -   5        $ VehicleRegView��5`      $��1��6'   $��0��67   
�������.+�5a      �� $��Vehicle Reg #��6   $��Center=�6,   $��	28,25,0,0q�6I   $��Center=�6\   $��95��6w   $	��445��6�   $
��Bold"�6�   $��40(�6�   ���	#DD080D21$��Segoe UI Semibold)�6�   ���	#FF48536E��6�   Z� 6�   5c      � 5e   
   -   5        $ VehicleDetailView��5e      $��1��6*   $��1��6:   
�������$��2,2,0,0q�6[     5h      �� 5i      $	��225 �6#   �� 5j      $��* �6#    5m      �� 5n      $��30 �6    �� 5o      $	��150 �6    �� 5p      $	��200 �6    �� 5q      $��56 �6    .+�5t      � $��0��6   $��1��6    $��1��60   $��2,0,0,0q�6D   .+�5u      �� -   5         ��Name$ VehicleOptionsMenu��5u      ���	#FF5C99D6$��Disabled=�6N   .@�5v      �� -   5         ��Name$ vEdit��5v   #   $��25��62   $��25��6>   .��5w      �� $ Vertical=�6%   .+�5x        $
 Home=�66   $��25��6B   $��25��6N   $��12q�6Y   5y      5z      �� 5{      -   5        $ vDelete��5{   #   $��25��64   $��25��6@   .��5|      �� $ Vertical=�6%   .+�5}        $ CarMultiple=�66   $��25��6I   $��25��6U   $��12q�6`   5~      5      5�      5�      � 5�      $��3��6   $��1��6!   $��2,0,0,0q�61   .+�5�      �� $
��Save��6   $��1��6(   $
��Left=�68   $��
161,10,0,0q�6S   $��3��6g   $	��Top=�6t   $	��102��6�   $��36��6�   ���	#FF067255$��16(�6�   $
��Bold"�6�   �� 5�      $��Cancel��6   $��1��6*   $
��Left=�6:   $��	10,10,0,0q�6U   $��3��6h   $	��Top=�6u   $	��101��6�   $��36��6�   ���	#FF9B1628$��16(�6�   $
��Bold"�6�   5�      5�      5�      5�      