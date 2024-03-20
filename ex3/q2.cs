/*
2. Escreva um programa em C# que utilize uma única expressão lambda para fazer todas as operações da questão 1. 
Em seguida, exiba o resultado na tela.
*/

Func<int, int, int[]> operacoes = (int x, int y) =>
{
    return [x + y, x - y, x * y, x / y, x % y];
};

Console.Write("NUMERO 1> ");
int num1P;
var num1 = "";
while (!int.TryParse(num1 = Console.ReadLine(), out num1P))
{
    Console.Write("DIGITE APENAS NUMEROS > ");
}

Console.Write("NUMERO 2> ");
int num2P;
var num2 = "";
while (!int.TryParse(num2 = Console.ReadLine(), out num2P))
{
    Console.Write("DIGITE APENAS NUMEROS > ");
}

int[] op = operacoes(num1P, num2P);

Console.WriteLine();
Console.WriteLine("SOMA: " + operacoes[0]);
Console.WriteLine("SUB: " + operacoes[1]);
Console.WriteLine("MUL: " + operacoes[2]);
Console.WriteLine("DIV: " + operacoes[3]);
Console.WriteLine("RES-DIV: " + operacoes[4]);
Console.WriteLine();