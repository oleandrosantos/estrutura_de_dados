using System;

namespace algorithms
{
  public static class SeachAlgorithms
  {
    public static int? BinaryNumberSeach(int[] listaNumeros, int numero)
    {
      int baixo = 0;
      int alto = listaNumeros.Length - 1;
      while (baixo <= alto)
      {
        int meio = (baixo + alto) / 2;
        int chute = listaNumeros[meio];
        if (chute == numero)
          return meio;
        if (chute > numero)
          alto = meio - 1;
        if (chute < numero)
          baixo = meio + 1;
      }
      return null;
    }
  }
}