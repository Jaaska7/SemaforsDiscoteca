   M S B A M L   `   `   `  ����D  @Diskoteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LlistesLlistes  5          Llistes.MainWindow   5   
   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      'localclr-namespace:Llistes     5        � Title$  Discotek��5      $	��450��6   $	��800��6   .��5	      ]� .+�5
   
   �� $
��Left=�6   $	��402��6+    �� Orientation$ Vertical=�68   $
��0,20q�6O   .+�5      �� -   5        $��Afegir��5      $	��100��6>   $��
10,30,10,0q�6J   $��50��6^   �� 5      -   5        $��Eliminar��5      $	��100��6B   $��
10,20,10,0q�6N   $��50��6b   �� 5      -   5        $��Moure��5      $	��100��6<   $��
10,20,10,0q�6H   $��50��6\   5      �� 5   
   -   5         ��Name$ IbPrincipal��5       �� SelectionMode$ Multiple=�6'   $	��254��6p   $��30,0,0,0q�6|   $	��325��6�   $
��Left=�6�   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5      $
��Auto �6/   .+�5      �� $��0��6    $��60��6J   $��60��6U   ��60   �� *Imatge+6U   �� 5      $��1��6%   $��Center=�65   .+�5      �� $
��Bold"�6(   $��	spacemono)�6:    �� TextAlignment$ Center=�6Q   ��6h   �� *Nom+� 5       � Maximum$ 80Q�6*   $��15��6N   $	��100��6Z    � Value 67   �� *Edat+6Z   5      5      5      5       �� 5!   
   -   5        $ IbDesti��5!      $	��254��6#   $ Multiple=�6/   $��30,0,0,0q�6H   $	��325��6Z   $
��Left=�6g   ��5"      �� 5#      .R�5$      �  5%      �� 5&      $
��Auto �6/   �� 5'      $
��Auto �6/   .+�5)      �� $��0��6    $��60��6J   $��60��6U   ��60   �� *Imatge+6U   �� 5*      $��1��6%   $��Center=�65   .+�5+      �� $
��Bold"�6(   $��	spacemono)�6:   $ Center=�6Q   ��6h   �� *Nom+� 5,      $ 80Q�6*   $��15��6N   $	��100��6Z    67   �� *Edat+6Z   �� 5-      $ Center=�6(   �� 5.   "   $�Temps: ��6&    �� 5/   "   �6&   �� *TiempoRestante+ �� 50   "   $� segons��6&   51      52      53      54      56      57      58      