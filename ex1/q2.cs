/*
**2 - Como atribuir o valor de um array 'a' para um array 'b' e, em seguida, modificar 'b' sem afetar o array original?**

Usando o método
CopyTo de objetos array, podemos copiar o conteúdo de um array para outro array iniciado anteriormente, 
assim o array a copiar não faz referência ao bloco de memória do array original. Segue-se abaixo um exemplo:
*/

int[] a = {1,2,3};
int[] b = new int[3];

//array ‘a’ copia para array ‘b’ todo seu conteúdo, iniciando na posição 0
a.CopyTo(b,0);

//altera para 5 o valor da posição 2 do array ‘b’
b[2] = 5;
Console.WriteLine("\nArray A:");
foreach(int c in a){
  Console.WriteLine(c);
}
Console.WriteLine("\nArray B:");
foreach(int c in b){
  Console.WriteLine(c);
}