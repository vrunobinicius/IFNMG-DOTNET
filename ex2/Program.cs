/*
Utilize os conhecimentos vistos em sala de aula sobre o sistemas de tipos (especialmente sobre os tipos de valor e referência) da Linguagem C#. 
Crie um enunciado de questão que seja capaz de avaliar se quem resolver entendeu a diferenças entre os tipos de valor e referência.
*/

//Considere as seguintes declarações em C#:
int val1 = 10;
int val2 = val1;
val2 = 20;

string ref1 = "Hello";
string ref2 = ref1;
ref2 = "World";

/*Após a execução deste código, quais serão os valores de val1, val2, ref1 e ref2? 
Explique por que os valores são esses, 
considerando a diferença entre tipos de valor e tipos de referência em C#.*/

//R:
/*Os tipos 
de valor (como `int`) são copiados por valor, 
o que significa que alterar `val2` 
não afeta `val1`. Por outro lado, os tipos de referência (como `string`) 
são copiados por referência, 
mas como as strings em C# são imutáveis, a alteração em `ref2` não afeta `ref1`.*/