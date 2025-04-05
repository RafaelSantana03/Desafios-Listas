namespace Listas_Desafio_04
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 4, 5, 6, 4, 7, 8, 5, 9 };

            HashSet<int> duplicados = new HashSet<int>();
            HashSet<int> unicos = new HashSet<int>();

            foreach (var item in numeros)
            {
                if(!unicos.Add(item))
                duplicados.Add(item);
            }
            foreach (var item in duplicados)
            {
                //Console.WriteLine(item);
            }
            Console.WriteLine(string.Join(", ", duplicados));
        }
    }
}

