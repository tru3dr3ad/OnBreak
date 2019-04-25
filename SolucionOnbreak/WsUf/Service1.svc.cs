using BibliotecaClases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WsUf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public double Uf()
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
            uf = uf.Replace('.', ',');
            double ufValor = double.Parse(uf);
            return ufValor;
        }
    }
}
