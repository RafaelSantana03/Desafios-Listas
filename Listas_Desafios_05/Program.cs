using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista1 = new List<int> { 1, 3, 5, 7 };
        List<int> lista2 = new List<int> { 2, 4, 6, 8 };

        List<int> resultado = new List<int>();

        int i = 0; // índice para lista1
        int j = 0; // índice para lista2

        // Mesclando enquanto houver elementos nas duas listas
        while (i < lista1.Count && j < lista2.Count)
        {
            if (lista1[i] < lista2[j])
            {
                resultado.Add(lista1[i]);
                i++;
            }
            else
            {
                resultado.Add(lista2[j]);
                j++;
            }
        }

        // Adiciona os elementos restantes de lista1 (se houver)
        while (i < lista1.Count)
        {
            resultado.Add(lista1[i]);
            i++;
        }

        // Adiciona os elementos restantes de lista2 (se houver)
        while (j < lista2.Count)
        {
            resultado.Add(lista2[j]);
            j++;
        }

        // Exibe o resultado final
        Console.WriteLine("Lista mesclada e ordenada:");
        Console.WriteLine(string.Join(", ", resultado));
    }
}
