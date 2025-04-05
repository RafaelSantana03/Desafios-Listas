namespace Listas_Desafios_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("[");
            foreach (var item in numeros)
            {
                if (item % 2 == 0)
                {
                    Console.Write($" {item},");
                }
            }
            Console.WriteLine(" ]");
        }
    }
}
