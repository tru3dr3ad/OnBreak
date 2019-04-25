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
    /// Lógica de interacción para WpfContrato.xaml
    /// </summary>
    public partial class WpfContrato : MetroWindow
    {
        public WpfContrato()
        {
            InitializeComponent();
        }

        private void BtnAgregarContrato_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato contrato = new Contrato();
                ContratoControlador controlador = new ContratoControlador();
                string nroContrato = DateTime.Now.ToString("yyyyMMddHHmm");
                string fechaInicio = dtpFechaInicio.SelectedDate.Value.Date.ToString();
                string fechaTermino = dtpFechaTermino.SelectedDate.Value.Date.ToString();
                string horaInicio = dtpHoraInicio.SelectedTime.Value.ToString();
                string horaTermino = dtpHoraTermino.SelectedTime.Value.ToString();
                string direccion = txtDireccionContrato.Text;
                bool estaVigente = true;
                string observaciones = txtObservaciones.Text;
                contrato.NroContrato = float.Parse(nroContrato);
                contrato.CreacionContrato = fechaInicio;
                contrato.TerminoContrato = fechaTermino;
                contrato.HoraIncio = horaInicio;
                contrato.HoraTermino = horaTermino;
                contrato.DireccionContrato = direccion;
                contrato.EstaVigente = estaVigente;
                contrato.Observaciones = observaciones;
                txtNroContrato.Text = nroContrato;
                if (controlador.AgregarContrato(contrato))
                {
                    MessageBox.Show("Contrato Agregado");
                    LimpiarContrato();
                }
                else
                {
                    MessageBox.Show("No Agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar Contrato: "+ex);
            }
        }

        private void BtnEvento_Click(object sender, RoutedEventArgs e)
        {
            WpfEvento evento = new WpfEvento();
            evento.Show();
        }

        private void BtnModificarContrato_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato nuevoContrato = new Contrato();
                ContratoControlador controlador = new ContratoControlador();
                string nroContrato = DateTime.Now.ToString("yyyyMMddHHmm");
                string fechaInicio = dtpFechaInicio.SelectedDate.Value.Date.ToString();
                string fechaTermino = dtpFechaTermino.SelectedDate.Value.Date.ToString();
                string horaInicio = dtpHoraInicio.SelectedTime.Value.ToString();
                string horaTermino = dtpHoraTermino.SelectedTime.Value.ToString();
                string direccion = txtDireccionContrato.Text;
                bool estaVigente = true;
                string observaciones = txtObservaciones.Text;
                nuevoContrato.NroContrato = float.Parse(nroContrato);
                nuevoContrato.CreacionContrato = fechaInicio;
                nuevoContrato.TerminoContrato = fechaTermino;
                nuevoContrato.HoraIncio = horaInicio;
                nuevoContrato.HoraTermino = horaTermino;
                nuevoContrato.DireccionContrato = direccion;
                nuevoContrato.EstaVigente = estaVigente;
                nuevoContrato.Observaciones = observaciones;
                txtNroContrato.Text = nroContrato;
                if (controlador.ModificarContrato(nuevoContrato))
                {
                    MessageBox.Show("Contrato Modificado");
                    LimpiarContrato();
                }
                else
                {
                    MessageBox.Show("No Modifico");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar: "+ ex);
            }
        }
        private void BtnTerminarContrato_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato contrato = new Contrato();
                ContratoControlador controlador = new ContratoControlador();
                bool estaTerminado = controlador.TerminarContrato(contrato);
                if (estaTerminado)
                {
                    MessageBox.Show("Contrato Terminado");
                }
                else
                {
                    MessageBox.Show("Contrato no ha finalizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al terminar contrato: "+ex);
            }
        }
        private void LimpiarContrato()
        {
            txtNroContrato.Clear();
            txtEstaVigente.Clear();
            dtpFechaInicio.SelectedDate = null;
            dtpFechaTermino.SelectedDate = null;
            dtpHoraInicio.SelectedTime = null;
            dtpHoraTermino.SelectedTime = null;
            txtDireccionContrato.Clear();
            txtEvento.Clear();
            txtObservaciones.Clear();
        }
    }
}
