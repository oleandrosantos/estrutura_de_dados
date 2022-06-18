using System;
using algorithms;

namespace estrutura_de_dados
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] lista = new int[] { 1, 2, 3, 4, 5, 6, 7, 14, 15, 22, 33, 55, 51, 56, 121, 213, 4123, 12314 };
      Console.WriteLine("Digite um numero: ");
      int x = Int32.Parse(Console.ReadLine());
      Console.WriteLine(SeachAlgorithms.BinaryNumberSeach(lista, x));
    }
  }

}