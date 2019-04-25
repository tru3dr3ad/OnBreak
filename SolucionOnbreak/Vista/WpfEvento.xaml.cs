using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using BibliotecaClases;
using BibliotecaControlador;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para WpfEvento.xaml
    /// </summary>
    public partial class WpfEvento : MetroWindow
    {
        public WpfEvento()
        {
            InitializeComponent();
        }

        private void BtnCalcularValor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Evento evento = new Evento();
                EventoControlador controlador = new EventoControlador();
                UfControlador ufControlador = new UfControlador();
                int valorBase = int.Parse(txtValorBase.Text);
                int personal = int.Parse(txtPersonal.Text);
                int asistentes = int.Parse(txtAsistentes.Text);
                evento.ValorBase = valorBase;
                evento.RecargoAsistentes = asistentes;
                evento.RecargoPersonal = personal;
                double calculado = ufControlador.CalcularEvento(evento);
                if (calculado>0)
                {
                    MessageBox.Show("El valor del evento es : "+ calculado);
                }
                else
                {
                    MessageBox.Show("No ha sido calculado");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: "+ex);
            }
        }
    }
}
