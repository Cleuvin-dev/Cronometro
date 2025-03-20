using System.Threading;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("S - Contagem em Segundos => 10s segundos");
      Console.WriteLine("M - Contagem em Minuto => 1m = 1 minuto");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("Quanto tempo deseja contar?");

      string dadoInformado = Console.ReadLine().ToLower();
      char tipo = char.Parse(dadoInformado.Substring(dadoInformado.Length - 1, 1));
      int tempo = int.Parse(dadoInformado.Substring(0, dadoInformado.Length - 1));
      int multiplicador = 1;

      if (tipo == 'm')
        multiplicador = 60;

      if (tempo == 0)
        Environment.Exit(0);

      PreStart(tempo * multiplicador);
      Start(tempo);

    }

    static void PreStart(int v)
    {
      Console.Clear();
      Console.WriteLine("Preparar..");
      Thread.Sleep(1000);
      Console.WriteLine("Apontar...");
      Thread.Sleep(1000);
      Console.WriteLine("Vamoss..");
      Thread.Sleep(2000);
    }
    static void Start(int tempo)
    {
      int tempoAtual = 0;

      while (tempoAtual != tempo)
      {
        Console.Clear();
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);
      }
      Console.Clear();
      Console.WriteLine("Cronometro finalizado!");
      Thread.Sleep(2000);
      Menu();
    }









  }
}