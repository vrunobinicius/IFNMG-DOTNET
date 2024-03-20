/*
2. Escreva um programa que use switch para encontrar o valor máximo entre dois números
*/

int number1, number2;

Console.WriteLine("Digite o primeiro NÚMERO: ");
while(!int.TryParse(Console.ReadLine(), out number1)) {
    Console.WriteLine("Somente NÚMEROS: ");
}

Console.WriteLine("Digite o segundo NÚMERO: ");
while(!int.TryParse(Console.ReadLine(), out number2)) {
    Console.WriteLine("Somente NÚMEROS: ");
}

switch((number1 > number2)) {
    case true:
    Console.WriteLine("O maior é " + number1);
    break;
    case false:
    Console.WriteLine("O maior é " + number2);
    break;
}