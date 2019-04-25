using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaControlador
{
    public class EventoControlador
    {
        static List<Evento> eventos;
        public EventoControlador()
        {
            if (eventos ==null)
            {
                eventos = new List<Evento>();
            }
        }
        public bool ExisteEvento(int idEvento)
        {
            try
            {
                foreach (Evento item in eventos)
                {
                    if (item.IdEvento.Equals(idEvento))
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
        public bool AgregarEvento(Evento evento)
        {
            try
            {
                if (ExisteEvento(evento.IdEvento) == false)
                {
                    eventos.Add(evento);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarEvento(int idEvento)
        {
            try
            {
                foreach (Evento item in eventos)
                {
                    if (item.IdEvento.Equals(idEvento))
                    {
                        eventos.Remove(item);
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
        public List<Evento> ListarEventos()
        {
            try
            {
                return eventos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
