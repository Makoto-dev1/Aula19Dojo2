using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.IngressoValor = 23.90f;
            //Chamando os métodos
            bilhete.ImprimirValor();
            bilhete.AdicionarValor();

            System.Console.WriteLine("A diferença de valores é: " + bilhete.valorAdicional);
            
        }
    }
}
