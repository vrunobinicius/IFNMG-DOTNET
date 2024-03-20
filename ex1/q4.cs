/*
**4 - Pesquise e apresente uma forma de exibir todos os elementos da variável “nomes” do exemplo anterior, 
sem usar uma estrutura de repetição expliticitamente, nos moldes tradicionais.**

Podemos usar o método ForEach do objeto ‘nomes’ enviando como ação o método WriteLine da class Console (Console.WriteLine):
*/
List<string> nomes = new List<string>();
nomes.AddRange(new [] {".net", "2023", "ifnmg"});
nomes.ForEach(Console.WriteLine);