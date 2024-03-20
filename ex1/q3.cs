/*
3 - Explique cada comando e o que acontece no seguinte código.
*/
List<string> nomes = new List<string>();
nomes.AddRange(new [] {".net", "2023", "ifnmg"});
Console.WriteLine(nomes);
/*
Primeiramente é criado uma lista do tipo string, chamada ‘nomes’. 
Após isso o método AddRange, adiciona os elementos de uma determinada lista na lista ‘nomes’.
Finalmente em uma tentativa de imprimir o conteudo da lista ‘nomes’, é acionado o seu método ToString.
*/