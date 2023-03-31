using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.Models
{
 public class Nokia : Smartphone
    {
        public Nokia(string numero, string imie, string modelo, int memoria) : base(numero, imie, modelo, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo (string nomeApp) 
        {
            Console.WriteLine($"Instalando aplicativos {nomeApp} no Nokia");
        }
    }
}