   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   @ <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista 5	   	      Vista.WpfCliente   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   localclr-namespace:Vista  5	   	     � Title$  CLIENTE��5   	   $	��450��6   $	��538��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   .��5      � .+�5   
   �� -   5         ��Name$ txtRutCliente��5      $
��Left=�6)   $��23��6D   $��
207,38,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $
��RUT:��6   $
��Left=�6   $��	72,38,0,0q�6:   $	��Top=�6M   �� 5   
   -   5        $ txtRazonSocial��5      $
��Left=�6*   $��23��6E   $��
207,69,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   $��RAZON SOCIAL:��6   $
��Left=�6(   $��	72,69,0,0q�6C   $	��Top=�6V   �� 5   
   -   5        $ txtNombreCliente��5      $
��Left=�6,   $��23��6G   $��207,100,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   $��NOMBRE:��6   $
��Left=�6"   $��
72,100,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5        $ txtMailCliente��5      $
��Left=�6*   $��23��6E   $��207,131,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��MAIL:��6   $
��Left=�6    $��
72,131,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $ txtDireccionCliente��5      $
��Left=�6/   $��23��6J   $��207,162,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5   
   $��
DIRECCION:��6   $
��Left=�6%   $��
72,162,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ txtTelefono��5      $
��Left=�6'   $��23��6B   $��207,193,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   $��	TELEFONO:��6   $
��Left=�6$   $��
72,193,0,0q�6?   $	��Top=�6S   �� 5   
   $��ACTIVIDAD EMPRESA:��6   $
��Left=�6-   $��
72,224,0,0q�6H   $	��Top=�6\   �� 5   
   $��TIPO DE EMPRESA:��6   $
��Left=�6+   $��
72,255,0,0q�6F   $	��Top=�6Z   �� 5   
   -   5         ��Name$ cmbActividadEmpresa��5      $
��Left=�60   $��207,224,0,0q�6K   $	��Top=�6`   $	��120��6x    � ContextMenu 5      �� 5      5      �� 5    
   -   5        $ cmbTipoEmpresa��5       $
��Left=�6+   $��207,255,0,0q�6F   $	��Top=�6[   $	��120��6s   �� 5!   
   -	   5         ��Name$ btnAgregarCliente��5!      $��AGREGAR��6,   $
��Left=�6>   $��
397,35,0,0q�6Y   $	��Top=�6m   $	��101��6�   6�   �� 5"   
   -
   5        $ btnModificar��5"      $��	MODIFICAR��6'   $
��Left=�6;   $��
397,80,0,0q�6V   $	��Top=�6j   $	��101��6�   6�   �� 5#   
   -   5        $ btnEliminar��5#      $��ELIMINAR��6&   $
��Left=�69   $��397,128,0,0q�6T   $	��Top=�6i   $	��101��6�   6�   �� 5$   
   -   5        $ btnBuscarCliente��5$      $��BUSCAR��6+   $
��Left=�6<   $��397,173,0,0q�6W   $	��Top=�6l   $	��101��6�   6�   5&      5'      