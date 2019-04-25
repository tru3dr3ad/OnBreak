using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaControlador
{
    public class ClienteControlador
    {
        static List<Cliente> clientes;
        public ClienteControlador()
        {
            if (clientes == null)
            {
                clientes = new List<Cliente>();
            }
        }
        public bool ExisteCliente(string rut)
        {
            try
            {
                foreach (Cliente item in clientes)
                {
                    if (item.RutCliente.Equals(rut))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                if (ExisteCliente(cliente.RutCliente) == false)
                {
                    clientes.Add(cliente);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarCliente(string rut)
        {
            try
            {
                foreach (Cliente item in clientes)
                {
                    if (item.RutCliente.Equals(rut))
                    {
                        clientes.Remove(item);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ModificarCliente(Cliente nuevoCliente)
        {
            try
            {
                bool respuesta = false;
                foreach (Cliente item in clientes)
                {
                    if (item.RutCliente.Equals(nuevoCliente.RutCliente))
                    {
                        item.RutCliente = nuevoCliente.RutCliente;
                        item.RazonSocial = nuevoCliente.RazonSocial;
                        item.NombreCliente = nuevoCliente.NombreCliente;
                        item.MailCliente = nuevoCliente.MailCliente;
                        item.DireccionCliente = nuevoCliente.DireccionCliente;
                        item.Telefono = nuevoCliente.Telefono;
                        item.ActividadEmpresa = nuevoCliente.ActividadEmpresa;
                        item.TipoEmpresa = nuevoCliente.TipoEmpresa;
                        respuesta = true;
                    }
                }
                return respuesta;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Cliente> ListarClientes()
        {
            try
            {
                return clientes;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Cliente BuscarCliente(string rut)
        {
            try
            {
                foreach (var item in clientes)
                {
                    if (item.RutCliente.Equals(rut))
                    {
                        Cliente cliente = new Cliente();
                        cliente.RutCliente = item.RutCliente;
                        cliente.RazonSocial = item.RazonSocial;
                        cliente.NombreCliente = item.NombreCliente;
                        cliente.MailCliente = item.MailCliente;
                        cliente.DireccionCliente = item.DireccionCliente;
                        cliente.Telefono = item.Telefono;
                        cliente.ActividadEmpresa = item.ActividadEmpresa;
                        cliente.TipoEmpresa = item.TipoEmpresa;
                        return cliente;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
