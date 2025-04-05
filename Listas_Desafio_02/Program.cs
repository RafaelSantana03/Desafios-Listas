namespace Listas_Desafio_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 5, 8, 12, 3, 7, 9 };

            int maiorValor = 0;
            int segundoMaiorValor = 0;

            foreach (var item in numeros)
            {
                if (item > maiorValor)
                {
                    segundoMaiorValor = maiorValor;
                    maiorValor = item;
                }
                else if (item > segundoMaiorValor && item < maiorValor)
                {
                    segundoMaiorValor = item;
                }   
            }
            Console.WriteLine(segundoMaiorValor);
        }

    }

}
