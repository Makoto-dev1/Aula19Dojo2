using System;

namespace Aula19Dojo2
{
    public class IngressoVIP : Ingresso
    {
        public float valorAdicional = 50.0f;

        public void AdicionarValor(){
        float newValor = IngressoValor + valorAdicional;
        
        //Muda a cor de uma linha
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("O valor VIP é : {0:c}",newValor);

        //Reseta a cor do terminal
        Console.ResetColor();
    }
    }
}