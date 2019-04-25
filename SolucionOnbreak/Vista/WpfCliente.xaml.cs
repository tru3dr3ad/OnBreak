using MahApps.Metro.Controls;
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
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using BibliotecaClases;
using BibliotecaControlador;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para wpfCliente.xaml
    /// </summary>
    public partial class WpfCliente : MetroWindow
    {
        public WpfCliente()
        {
            InitializeComponent();
        }

        private void LimpiarCliente()
        {
            txtRutCliente.Clear();
            txtRazonSocial.Clear();
            txtNombreCliente.Clear();
            txtMailCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefono.Clear();
        }
        private void BtnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteControlador controlador = new ClienteControlador();
                string rut = txtRutCliente.Text;
                string razonSocial = txtRazonSocial.Text;
                string nombreCliente = txtNombreCliente.Text;
                string mailCliente = txtMailCliente.Text;
                string direccionCliente = txtDireccionCliente.Text;
                int telefono = int.Parse(txtTelefono.Text);
                string actividad = cmbActividadEmpresa.Text;
                string tipoEmpresa = cmbTipoEmpresa.Text;
                cliente.RutCliente = rut;
                cliente.RazonSocial = razonSocial;
                cliente.NombreCliente = nombreCliente;
                cliente.MailCliente = mailCliente;
                cliente.DireccionCliente = direccionCliente;
                cliente.Telefono = telefono;
                cliente.ActividadEmpresa = actividad;
                cliente.TipoEmpresa = tipoEmpresa;
                bool estaAgregado = controlador.AgregarCliente(cliente);
                if (estaAgregado)
                {
                    MessageBox.Show("Agregado");
                    LimpiarCliente();
                }
                else
                {
                    MessageBox.Show("Ya Existe!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar: " + ex);
            }
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente nuevoCliente = new Cliente();
                ClienteControlador controlador = new ClienteControlador();
                string rut = txtRutCliente.Text;
                string razonSocial = txtRazonSocial.Text;
                string nombreCliente = txtNombreCliente.Text;
                string mailCliente = txtMailCliente.Text;
                string direccionCliente = txtDireccionCliente.Text;
                int telefono = int.Parse(txtTelefono.Text);
                string actividad = cmbActividadEmpresa.Text;
                string tipoEmpresa = cmbTipoEmpresa.Text;
                nuevoCliente.RutCliente = rut;
                nuevoCliente.RazonSocial = razonSocial;
                nuevoCliente.NombreCliente = nombreCliente;
                nuevoCliente.MailCliente = mailCliente;
                nuevoCliente.DireccionCliente = direccionCliente;
                nuevoCliente.Telefono = telefono;
                nuevoCliente.ActividadEmpresa = actividad;
                nuevoCliente.TipoEmpresa = tipoEmpresa;
                bool estaModificado = controlador.ModificarCliente(nuevoCliente);
                if (estaModificado)
                {
                    MessageBox.Show("Cliente Modificado");
                    LimpiarCliente();
                }
                else
                {
                    MessageBox.Show("No ha sido modificado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar: " + ex);
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClienteControlador controlador = new ClienteControlador();
                string rut = txtRutCliente.Text;
                bool estaEliminado = controlador.EliminarCliente(rut);
                if (estaEliminado)
                {
                    MessageBox.Show("Cliente Eliminado");
                    txtRutCliente.Clear();
                    txtRazonSocial.Clear();
                    txtNombreCliente.Clear();
                    txtMailCliente.Clear();
                    txtDireccionCliente.Clear();
                    txtTelefono.Clear();
                }
                else
                {
                    MessageBox.Show("No ha sido Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex);
            }
        }
        private void BtnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClienteControlador controlador = new ClienteControlador();
                string rut = txtRutCliente.Text;
                Cliente cliente = new Cliente();
                cliente = controlador.BuscarCliente(rut);
                if (cliente != null)
                {
                    MessageBox.Show("Cliente Encontrado");
                    txtRazonSocial.Text = cliente.RazonSocial;
                    txtNombreCliente.Text = cliente.NombreCliente;
                    txtMailCliente.Text = cliente.MailCliente;
                    txtDireccionCliente.Text = cliente.DireccionCliente;
                    txtTelefono.Text = "" + cliente.Telefono;

                }
                else
                {
                    MessageBox.Show("No Encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar: " + ex);
            }
        }
    }
}
