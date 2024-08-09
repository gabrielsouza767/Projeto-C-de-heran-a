using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
     class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo,string Imei,int memoria) { 
            this.numero=numero;
            Modelo=modelo;
            IMEI=Imei;
            Memoria=memoria;
        }
        public override void InstalarApps(string nome)
        {
            if (nome == "WhatsApp")
            {
                Console.Write("Instalando aplicativo");
            }
            else
            {
                Console.WriteLine("Nao foi possivel instalar");
            }
        }
    }
}
