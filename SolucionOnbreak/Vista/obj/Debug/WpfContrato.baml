   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    WPFToolkit.ExtendedR<clr-namespace:Xceed.Wpf.Toolkit;assembly=WPFToolkit.ExtendedXceed.Wpf.Toolkit 5   	   @ <Vista, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistaVista 5
   	      Vista.WpfContrato   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   Jtoolkit<clr-namespace:Xceed.Wpf.Toolkit;assembly=WPFToolkit.Extended  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	   	   localclr-namespace:Vista  5
   	     � Title$  Contrato��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   .��5      � .+�5   
   �� -   5         ��Name$ txtNroContrato��5      $
��Left=�6*   $��23��6E   $��
145,53,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��145��6�   {�.  6�   �� 5   
   $��Nro Contrato:��6   $
��Left=�6(   $��	59,53,0,0q�6C   $	��Top=�6V   �� 5   
   $��Fecha Inicio:��6   $
��Left=�6(   $��	59,84,0,0q�6C   $	��Top=�6V   �� 5   
   $��Hora Inicio:��6   $
��Left=�6'   $��
59,115,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $ txtDireccionContrato��5      $
��Left=�60   $��23��6K   $��145,148,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��145��6�   �� 5   
   $��
Direccion:��6   $
��Left=�6%   $��
59,148,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ txtEstaVigente��5      $
��Left=�6*   $��23��6E   $��
401,53,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��145��6�   {�.  6�   �� 5   
   $��Vigente:��6   $
��Left=�6#   $��
315,53,0,0q�6>   $	��Top=�6R   �� 5   
   $��Fecha Termino:��6   $
��Left=�6)   $��
315,84,0,0q�6D   $	��Top=�6X   �� 5   
   $��Hora Termino:��6   $
��Left=�6(   $��315,115,0,0q�6C   $	��Top=�6X   �� 5   
   -   5        $ 	txtEvento��5      $
��Left=�6%   $��23��6@   $��401,148,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��145��6�   {�.  6�   �� 5   
   $��Evento:��6   $
��Left=�6"   $��315,148,0,0q�6=   $	��Top=�6R   �� 5   
   -   5        $ txtObservaciones��5      $
��Left=�6,   $	��179��6G   $��145,179,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��401��6�   �� 5   
   $��Observaciones:��6   $
��Left=�6)   $��
59,179,0,0q�6D   $	��Top=�6X   �� 5   
   -   5         ��Name$ 	btnEvento��5      $	��...��6$   $
��Left=�62   $��554,148,0,0q�6M   $	��Top=�6b   $��31��6z   $��26��6�    � ToolTip$ Agrega un evento��6�   6�   �� 5   
   -   5        $ btnAgregarContrato��5      $��AGREGAR��6-   $
��Left=�6?   $��
611,91,0,0q�6Z   $	��Top=�6n   $��99��6�   6�   �� 5   
   -   5        $ btnTerminarContrato��5      $��TERMINAR��6.   $
��Left=�6A   $��611,168,0,0q�6\   $	��Top=�6q   $��99��6�   6�   �� 5   
   -	   5        $ btnModificarContrato��5      $��	MODIFICAR��6/   $
��Left=�6C   $��611,130,0,0q�6^   $	��Top=�6s   $��99��6�   6�   �� 5    
   -
   5        $ btnBuscarContrato��5       $��BUSCAR��6,   $
��Left=�6=   $��
611,53,0,0q�6X   $	��Top=�6l   $��99��6�   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ dtpFechaInicio��5!      $
��Left=�6-   $��
145,85,0,0q�6H   $	��Top=�6\      SelectedDateFormat$ Short=�6t   '   !MahApps.Metro.Controls.TimePicker  5"   
   -   5        	  Name$	 dtpHoraInicio��5"      $��25��65   $��145,115,504,280q�6A     5#   
   -   5        $ dtpFechaTermino��5#      $
��Left=�6.   $��
401,85,0,0q�6I   $	��Top=�6]     5$   
   -   5        $	 dtpHoraTermino��5$      $��25��66   $��401,116,248,279q�6B   5&      5'      