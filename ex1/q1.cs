/*
1 - É possível comparar tanto tipos de valor quanto tipos de referência
usando o método Equals? Dê, pelo menos, três exemplos distintos de
uso com tipos de valor e referência.
*/

Console.WriteLine("Tipos de valor:");
Console.WriteLine("\n");
//int
Console.WriteLine("int");
int valor = 3;
int valor2 = 4;
Console.WriteLine(valor.Equals(valor2));
valor  = valor2;
Console.WriteLine(valor.Equals(valor2));
Console.WriteLine("\n");
//float
Console.WriteLine("float");
float valorf = 5.3f;
float valor2f = 6.2f;
Console.WriteLine(valorf.Equals(valor2f));
valorf  = valor2f;
Console.WriteLine(valorf.Equals(valor2f));
Console.WriteLine("\n");
//bool
Console.WriteLine("bool");
bool valorb = true;
bool valor2b = false;
Console.WriteLine(valorb.Equals(valor2b));
valorb  = valor2b;
Console.WriteLine(valorb.Equals(valor2b));
Console.WriteLine("\n");
Console.WriteLine("Tipos de referencia:");
Console.WriteLine("\n");
Console.WriteLine("array");
int[] vetor = {0,1,2,3,4,5,6};
int[] vetor2 = {6,2,3,5,0,4,1};
Console.WriteLine(vetor.Equals(vetor2));
vetor = vetor2;
Console.WriteLine(vetor.Equals(vetor2));
Console.WriteLine("\n");
Console.WriteLine("list");
List<int> vetorl = new List<int>();
vetorl.AddRange(new [] {1,2,3});
List<int> vetorl2 = new List<int>();
vetorl2.AddRange(new [] {3,2,1});
Console.WriteLine(vetorl.Equals(vetorl2));
vetorl = vetorl2;
Console.WriteLine(vetorl.Equals(vetorl2));
Console.WriteLine("\n");
Console.WriteLine("string");
string nome = "Bruno";
string nome2 = "Onurb";
Console.WriteLine(nome.Equals(nome2));
nome =  nome2;
Console.WriteLine(nome.Equals(nome2));
Console.WriteLine("\n");