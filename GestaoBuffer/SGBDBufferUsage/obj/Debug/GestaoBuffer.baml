   M S B A M L   `   `   `  ����  SGBDBufferUsage"    SGBDBufferUsage.GestaoBuffer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  GestaoBuffer��5   	   $	��320��6   $	��600��6,    � 
ResizeMode$ CanMinimize=�6U    � WindowStartupLocation$ CenterScreen=�6n   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��50* �6   .+�5   
   �� $%��Algoritmo de Subst. de Páginas��6   $
��Left=�69   $��30��6T   $��	10,10,0,0q�6`   $	��Top=�6s   $	��202��6�    J� IsHitTestVisible .  6�   �� 5   
   -   5         ��Name$ comboAlgoritmo��5      $��	10,45,0,0q�6+   $	��Top=�6>   $
��Left=�6V   $	��202��6q   .@�5      ��  �� 
IsSelected . $	��LRU��66   �� 5      $	��MRU��6   5      �� 5   
   -   5         ��Name$ btnIniciarAlteracoes��5      $#��Carregar Páginas Automático��6/   $
��Left=�6U   $��	10,99,0,0q�6p   $	��Top=�6�   $	��202��6�   6�   �� 5   
   -   5        $ btnPausarAlteracoes��5      $��Parar��6.   $
��Left=�6>   $��
10,124,0,0q�6Y   $	��Top=�6m   $	��202��6�   $y�Hidden=�6�   �� 5   
   $��1��6   $��10,10,14,10q�6%   .+�5      �� $��34��6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Página Solicitada:��6   $
��Left=�65   �� 5      -   5        	 ��Name$	 	lblPagina��5      $�� ��6+   $	��103��66   5      �� 5      $��Páginas na Memória��6   $��5q�63   $	��232��6>   .��5      �� $��1��6   $&�� 5                               q�6/   {�.  .��5      �� 
���   �$��1q�61   ._�5      �� -   5        
 ��Name$
 
txtPaginas��5   $   $
��Wrap=�68   5      5      5      5      5!      5"      