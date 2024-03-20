/*
1. Escrever par ou ímpar na tela, a partir de uma variável:
a) com switch
b) com if sem else
c) sem nenhuma estrutura de controle
d) com operador ternário
*/

int number;

Console.WriteLine("Digite um NÚMERO: ");
while(!int.TryParse(Console.ReadLine(), out number)) {
    Console.WriteLine("Somente NÚMEROS: ");
}

//a) com switch
switch ( number%2 ) {
    case 0:
    Console.WriteLine("Par.");
    break;
    case 1:
    Console.WriteLine("Impar.");
    break;
}

//b) com if sem else
if(number % 2 == 0){
    Console.WriteLine("Par.");
}
if(number % 2 == 1){
    Console.WriteLine("Impar.");
}

//c) sem nenhuma estrutura de controle
String[] res = {"Par.","Impar."};
Console.WriteLine(res[number%2]);

//d) com operador ternário
string value = (number % 2 == 0) ? "Par.": "Impar.";
Console.WriteLine(value);