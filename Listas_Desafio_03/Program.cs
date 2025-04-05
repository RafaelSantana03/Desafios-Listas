using System.Net.WebSockets;
using System.Text;

namespace Listas_Desafio_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            List<int> invertida = new List<int>();

            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                invertida.Add(numeros[i]);
            }
            Console.WriteLine(string.Join(", ", invertida));


        }
    }
}