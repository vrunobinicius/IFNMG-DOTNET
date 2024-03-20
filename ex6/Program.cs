/*
Crie um programa que receba um conjunto de dados de entrada (int), que deve ser fornecido pelo usuário sequencialmente, sem tamanho pré-definido.

Implemente uma classe, que armazene e calcule a média e o desvio padrão dos dados fornecidos. 
Essa classe deve ter pelo menos um construtor, as propriedades (get e set), um método para receber um número da sequência, 
um para calcular a média e outro para o desvio padrão, e uma sobrecarga para ToString(). 
O usuário deve escolher se quer adicionar mais um número, ou verificar a média e o desvio ou finalizar.
*/
internal class Program
{
    private static void Main(string[] args)
    {

        string strMenu = " | 1 - Adicionar Numero; \n | 2 - Calcular Media e Desvio Padrão; \n | 3 - Imprimir lista \n | 4 - EXIT; \n";
        string option = "";

        List<int> l = new List<int>();
        int value;

        Calculator calc = new Calculator();
        calc.list = l;

        while (option != "4")
        {
            Console.WriteLine();
            Console.Write(strMenu);
            Console.WriteLine();

            Console.Write(">> ");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Adicione o número: ");
                    int.TryParse(Console.ReadLine(), out value);
                    l.Insert(l.Count, value);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Media: ");
                    Console.WriteLine(">> " + calc.getMedia());
                    Console.WriteLine("Desvio padrão: ");
                    Console.WriteLine(">> " + calc.desvioPadrao());
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    foreach (int v in l)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();
                    break;

            }
        }

        Console.WriteLine();
        foreach (int v in l)
        {
            Console.Write(v + " ");
        }
        Console.WriteLine();

    }
}

class Calculator
{
    public Calculator()
    {
        list = new List<int>();
    }

    public double getMedia()
    {
        double sum = list.Sum();
        double count = list.Count();
        return sum / count;
    }

    private double somatorio()
    {
        double sum = 0;
        foreach (int value in list)
        {
            sum += Math.Pow((value - getMedia()), 2);
        }
        return sum;
    }
    public double desvioPadrao()
    {
        double aux = somatorio() / list.Count;
        return aux = Math.Sqrt(aux);
    }

    public List<int> list { get; set; }

}