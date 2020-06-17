namespace Aula19Dojo2
{
    public class Ingresso
    {
        public float IngressoValor { get; set; }

        //Metodo
        public void ImprimirValor(){
            System.Console.WriteLine("O valor do ingresso é R$ " + IngressoValor);
        }
    }
}