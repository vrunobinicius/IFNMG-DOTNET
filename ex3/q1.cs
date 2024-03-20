/*
1. Escreva um programa em C# que receba dois números inteiros do usuário e exiba o resultado das seguintes operações: 
adição, subtração, multiplicação, divisão inteira e resto da divisão entre os números. 
Pesquisar uma forma de verificar se o tipo está correto.
*/

Console.Write("NUMERO 1> ");
int num1P;
var num1 = "";
while (!int.TryParse(num1 = Console.ReadLine(), out num1P)) {
    Console.Write("DIGITE APENAS NUMEROS > ");
}

Console.Write("NUMERO 2> ");
int num2P;
var num2 = "";
while (!int.TryParse(num2 = Console.ReadLine(), out num2P)) {
    Console.Write("DIGITE APENAS NUMEROS > ");
}

Console.WriteLine();
Console.WriteLine("SOMA: " + num1P + " + " + num2P + " = " + (num1P+num2P));
Console.WriteLine("SUB: " + num1P + " - " + num2P + " = " + (num1P-num2P));
Console.WriteLine("MUL: " + num1P + " * " + num2P + " = " + (num1P*num2P));
Console.WriteLine("DIV: " + num1P + " / " + num2P + " = " + (num1P/num2P));
Console.WriteLine("RES-DIV: " + num1P + " % " + num2P + " = " + (num1P%num2P));
Console.WriteLine();