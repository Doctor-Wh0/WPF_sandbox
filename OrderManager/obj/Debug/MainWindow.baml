   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   G COrderManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OrderManagerOrderManager 5   	   A%clr-namespace:OrderManager.ViewModelsOrderManager.ViewModels 5	   	   A%clr-namespace:OrderManager.ViewModelsOrderManager.ViewModels 5   	   7 clr-namespace:OrderManager.ViewsOrderManager.Views 5   	      OrderManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  5   	   &localclr-namespace:OrderManager  5   	   6
ViewModels%clr-namespace:OrderManager.ViewModels  5	   	   6
viewModels%clr-namespace:OrderManager.ViewModels  5   	   ,views clr-namespace:OrderManager.Views  5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $
��1080��6)   
������� � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_    � WindowStyle$
 None=�6�    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose	 �� DataType+  %OrderManager.ViewModels.ChatViewModel$  OrderManager.Views.ChatControl-  'OrderManager.ViewModels.OrdersViewModel&   OrderManager.Views.OrdersControl+  %OrderManager.ViewModels.HomeViewModel$  OrderManager.Views.HomeControl/  )OrderManager.ViewModels.AddOrderViewModel(	  "OrderManager.Views.AddOrderControl��%�  &	        &	 �     (�� �    5      *, +)(�� �    5      *, +)(�� �    5"      *, +)(��      5%      *, +)�� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ LeftMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ LeftMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      �� 5   
   "	  6   .R�5        5      �� 5   
   "	  6   .R�5         5!      �� 5"   
   "	  6   .R�5#        5$      �� 5%   
   "	  6   .R�5&      	  5'      5(      
 � Triggers
 5*      :� 5+   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ OpenMenuBtn��66   .[�5,      �� #��[  6   5-      :� 5.   
   $ ButtonBase.Click��6   $ HideMenuBtn��66   .[�5/      �� #��[ 6   50      .��52      � ���	#FFDEDEDE.+�53   
   � -   5         �Name$ GridMain��53      $��Right=�6!   $��Bottom=�6=   $	��540��6X   $
��1020��6e   .+�54      �� -   5         ��Name$ Pages��54      ��6,   �� *SelectedViewModel+55      � 56   
   $��60��6   $	��Top=�6   ���	#FF13688D.+�57      �� $��Заявки��6   $��Center=�6&   $��Center=�6C   $��22(�6^   �� 58      $��Center=�6   $��Right=�64    �� Orientation$ 
Horizontal=�6P   .+�59      �� $��Меню��6   $��Center=�6(   $��18(�6C   '
  !MaterialDesignThemes.Wpf.PopupBox
  5:      $��10q�6*    
  PlacementMode$ BottomAndAlignRightEdges=�66    
  	StaysOpen .   
  PopupContent. 5;      �� $	��150��6!   .+�5=      �� -   5        $��Закрыть��5=   !   63   5>      5?      5@      5A      � 5B   
   -   5        $ LeftMenu��5B      $��60��6!   $
��Left=�6,   ���	#FF183861 J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         
BlurRadius$ 2Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFAEAEAE��6B   .+�5F      �� .+�5G      � $	��150��6   
������� J� RenderTransformOrigin$ 0.5,0.5&�67   z�5H      V� 5I      .~�5J      �� �� 5K      �� 5L      T� 5M      5N      .+�5P      �� -   5         ��Name$ OpenMenuBtn��5P      $��60��62   $��60��6=   ���	#FF31577E$��Right=�6�   $	��Top=�6�   ��6I   Z� ��6_   Z� .��5Q      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�62   $��25��6>   $��25��6I   5R      �� 5S      -   5        $ HideMenuBtn��5S      $��60��62   $��60��6=   ���	#FF31577E$��Right=�6�   $	��Top=�6�   $y�	Collapsed=�6�   ��6I   Z� ��6_   Z� .��5T        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5U      �� 5V      $��80��6   $��Bottom=�6(   5W      �� 5Y      -   5         ��Name$ ListViewMenu��5Y      $��Disabled=�61   ���	#FF1368BD.@�5Z      �� -	   5         ��Name$ ItemHome��5Z   /   $��60��6#   .   (System.Windows.Interactivity.Interaction   Triggers 5[      /   )System.Windows.Interactivity.EventTrigger  5\         	EventName$ MouseLeftButtonUp��6-   .   (System.Windows.Interactivity.TriggerBase   Actions. 5]   "   6   0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *ToHomeCommand+5^      .��5`      �� $ 
Horizontal=�6%   .+�5a        $ HomeAccount=�66   $��25��6I   $��25��6U   $��10q�6`   $��Center=�6l   �� 5b      $��Стартовая��6(   $��Center=�69   $��20 10q�6T   5c      5d      �� 5e      -
   5        $ 
ItemOrders��5e   /   $��60��6#    5f        5g      $ MouseLeftButtonUp��6-   . 5h   "      68   �� *ToOrdersCommand+5i      .��5k      �� $ 
Horizontal=�6%   .+�5l        $ MeasuringTape=�66   $��25��6K   $��25��6W   $��10q�6b   $��Center=�6n   �� 5m      $��Заказы��6(   $��Center=�66   $��20 10q�6Q   5n      5o      �� 5p      -   5        $ ItemChat��5p   /   $��60��6#    5q        5r      $ MouseLeftButtonUp��6-   . 5s   "      68   �� *ToAddOrderCommand+5t      .��5v      �� $ 
Horizontal=�6%   .+�5w        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   $��Center=�6g   �� 5x      $��Лимиты��6(   $��Center=�66   $��20 10q�6Q   5y      5z      �� 5{      $��60��6#    5|        5}      $ MouseLeftButtonUp��6-   . 5~   "      68   �� *ToChatCommand+5      .��5�      �� $ 
Horizontal=�6%   .+�5�        $
 Chat=�66   $��25��6B   $��25��6N   $��10q�6Y   $��Center=�6e   �� 5�      $��Чат��6(   $��Center=�63   $��20 10q�6N   5�      5�      5�      5�      5�      5�      5�      