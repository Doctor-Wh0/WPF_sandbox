   M S B A M L   `   `   `  ����G  COrderManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:OrderManager.ViewsOrderManager.Views  5      9!clr-namespace:OrderManager.ModelsOrderManager.Models  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5	      $    OrderManager.Views.ChatControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:OrderManager.Views     5      4models!clr-namespace:OrderManager.Models     5      Bcol2clr-namespace:System.Collections;assembly=mscorlib     5	      .��5      � 
�������.+�5   
   �� -   5          ��Name$  ConnectDisconnectBtn��5      $
��Left=�6�   $��	26,19,0,0q�6�   $	��Top=�6�   $	��145��6�   ��6/   �� *	ConDiscon+��6M   �� *ConDisconCommand+��6r   �� *Text+ �� ElementName$ 	NameField��6�   �� 5   
   -   5         ��Name$ 	NameField��5      $
��Left=�6%   $��28��6@   $��
408,23,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $��Имя��6t   $	��Top=�6   $	��221��6�   $��16(�6�   
���   �6�   �� 5   
   -   5         ��Name$ MessagesField��5      $
��Left=�6J   $	��239��6e   $��	26,74,0,0q�6r   $	��Top=�6�   $	��741��6�   $��16(�6�   
���   ���6)   �� *
Messages+6�   �� 5   
   $��Ваше Имя:��6   $
��Left=�6$   $��
217,23,0,0q�6?   $	��Top=�6S   $	��151��6k   �� 5   
   -   5        $ MessageField��5      $�� ��6(   $
��Left=�60   $��63��6K   $��
26,333,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��741��6�   $��16(�6�   
���   �6�   �� 5   
   -   5        $  SendMessage��5      $��Отправить��6&   $
��Left=�6�   $��650,408,0,0q�6�   $	��Top=�6�   $	��117��6�   ��6:   �� *SendMessageCommand+��6a   �� *Text+$ MessageField��6�   5      5      