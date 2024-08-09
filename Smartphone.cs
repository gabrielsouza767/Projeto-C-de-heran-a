using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    abstract class Smartphone
    {
        public string numero;
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public virtual void Ligar() {
            if (numero=="123456")
            {
                Console.WriteLine("Fazendo ligação");
            }
            else
            {
                Console.WriteLine("Nao foi possivel efetuar ligação");
            }
            
        }
        public virtual void ReceberLigacao() {
            if (numero == "123456")
            {
                Console.WriteLine("Recebendo ligação");
            }
            else {
                Console.WriteLine("Nao foi possivel receber ligação");
            }
            
        }
        public abstract void InstalarApps(string nome);
    }
}
