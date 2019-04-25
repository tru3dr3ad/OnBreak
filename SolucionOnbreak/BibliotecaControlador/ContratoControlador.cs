using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaControlador
{
    public class ContratoControlador
    {
        static List<Contrato> contratos;
        public ContratoControlador()
        {
            if (contratos == null)
            {
                contratos = new List<Contrato>();
            }
        }
        public bool ExisteContrato(float nroContrato)
        {
            try
            {
                foreach (Contrato item in contratos)
                {
                    if (item.NroContrato.Equals(nroContrato))
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
        public bool AgregarContrato(Contrato contrato)
        {
            try
            {
                if (ExisteContrato(contrato.NroContrato)==false)
                {
                    contratos.Add(contrato);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool TerminarContrato(Contrato terminado)
        {
            try
            {
                bool terminar = false;
                foreach (Contrato item in contratos)
                {
                    if (item.NroContrato.Equals(terminado.NroContrato))
                    {
                        item.EstaVigente = false;
                        terminar = true;
                    }
                }
                return terminar;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ModificarContrato(Contrato nuevoContrato)
        {
            try
            {
                bool respuesta = false;
                foreach (Contrato item in contratos)
                {
                    if (ExisteContrato(nuevoContrato.NroContrato) == true)
                    {
                        item.NroContrato = nuevoContrato.NroContrato;
                        item.CreacionContrato = nuevoContrato.CreacionContrato;
                        item.TerminoContrato = nuevoContrato.TerminoContrato;
                        item.HoraIncio = nuevoContrato.HoraIncio;
                        item.HoraTermino = nuevoContrato.HoraTermino;
                        item.DireccionContrato = nuevoContrato.DireccionContrato;
                        item.EstaVigente = nuevoContrato.EstaVigente;
                        item.Observaciones = nuevoContrato.Observaciones;
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
        public List<Contrato> ListarContrato()
        {
            try
            {
                return contratos;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Contrato> BuscarContrato(int nroContrato)
        {
            try
            {
                List<Contrato> lista = new List<Contrato>();
                foreach (var item in contratos)
                {
                    if (item.NroContrato.Equals(nroContrato))
                    {
                        Contrato contrato = new Contrato();
                        contrato.NroContrato = item.NroContrato;
                        contrato.CreacionContrato= item.CreacionContrato;
                        contrato.TerminoContrato = item.TerminoContrato;
                        contrato.HoraIncio= item.HoraIncio;
                        contrato.HoraTermino = item.HoraTermino;
                        contrato.DireccionContrato = item.DireccionContrato;
                        contrato.EstaVigente = item.EstaVigente;
                        contrato.Observaciones = item.Observaciones;
                        lista.Add(contrato);
                        return lista;
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
