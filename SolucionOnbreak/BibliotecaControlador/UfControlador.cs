using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace BibliotecaControlador
{
    public class UfControlador
    {
        public double TraerUf()
        {
            UfDatos ufDatos;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mindicador.cl/api/uf");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            var json = streamReader.ReadToEnd();
            ufDatos = JsonConvert.DeserializeObject<UfDatos>(json);
            string uf = "";
            foreach (Serie item in ufDatos.serie)
            {
                uf = item.valor;
            }
            // uf = uf.Replace('.', ','); 
            double ufValor = double.Parse(uf);
            return ufValor;
        }
        public double CalcularEvento(Evento evento)
        {
            try
            {
                //
                double uf = TraerUf();
                int valorBase = evento.ValorBase;
                double valorAsistentes = 0;
                double valorPersonal = 0;
                //Asistentes
                if (evento.RecargoAsistentes >= 1 && evento.RecargoAsistentes <= 20)
                {
                    valorAsistentes = 3 * uf;
                }
                else if (evento.RecargoAsistentes >= 21 && evento.RecargoAsistentes <= 50)
                {
                    valorAsistentes = 5 * uf;
                }
                else if (evento.RecargoAsistentes > 51)
                {
                    int restaAsistentes = evento.RecargoAsistentes - 50;
                    double sumarUf = uf * 5;
                    int adicional = restaAsistentes / 20;
                    valorAsistentes = (adicional * (uf * 2) )+ sumarUf;
                }
                //Personal uf
                if (evento.RecargoPersonal == 2)
                {
                    valorPersonal = 2 * uf;
                }
                else if (evento.RecargoPersonal == 3)
                {
                    valorPersonal = 3 * uf;
                }
                else if (evento.RecargoPersonal == 4)
                {
                    valorPersonal = 3.5 * uf;
                }
                else if (evento.RecargoPersonal > 4)
                {
                    double sumar = uf * 3.5;
                    int restaPersonal = evento.RecargoPersonal - 4;
                    valorPersonal = ((restaPersonal * 0.5) * uf )+ sumar;
                }
                double totalEvento = valorBase + valorPersonal + valorAsistentes;
                return totalEvento;
            }
            catch (Exception)
            {
                return 0;
                //Console.WriteLine("Error al calcular: "+ ex);
            }
        }
    }
}
