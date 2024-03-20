/*
1. Crie um programa que calcule o valor de uma parcela de um determinado financiamento. 
O usuário deve fornecer a taxa de juros mensal, o número de parcelas, e o valor do bem. 
O programa deve fornecer o valor da parcela e permitir repetir a operação.
Link para a fórmula: https://mundoeducacao.uol.com.br/matematica/calculo-financiamento.htm
Link para uma calculadora online: https://www3.bcb.gov.br/CALCIDADAO/publico/exibirFormFinanciamentoPrestacoesFixas.do?method=exibirFormFinanciamentoPrestacoesFixas

Exemplo de Entrada:
No. de meses: 4
Taxa de juros mensal %: 1.99
Valor financiado: 1290.00

Exemplo de Saída
Parcela: 338.70
O total desse financiamento de 4
parcelas é 1354.80 reais,
sendo 64.80 de juros.
*/

// Variaveis
double taxaDeJurosMensal = 0;
int numeroDeParcelas = 0;
double valorDoBem = 0;

double CF = 0;
bool repetir = true;
string opcao;

do
{

    // Leitura das variaveis
    Console.WriteLine("Taxa de Juros Mensal: ");
    taxaDeJurosMensal = double.Parse(Console.ReadLine());

    Console.WriteLine("Numero de Parcelas: ");
    numeroDeParcelas = int.Parse(Console.ReadLine());

    Console.WriteLine("Valor do Bem: ");
    valorDoBem = double.Parse(Console.ReadLine());

    taxaDeJurosMensal = taxaDeJurosMensal/100;
    CF = taxaDeJurosMensal/(1 - Math.Pow((1 + taxaDeJurosMensal), -numeroDeParcelas));

    CF = CF * valorDoBem;

    Console.WriteLine("A parcela tem o valor de: R$" + Math.Round(CF, 2));

    Console.WriteLine("Deseja repetir a operação? Y/N: ");
    opcao = Console.ReadLine();
    if (opcao.ToUpper() == "N")
    {
        repetir = false;
    }
    else if (opcao.ToUpper() == "Y")
    {
        repetir = true;
    }
    else
    {
        Console.WriteLine(opcao + " não é uma opção conhecida, execução encerrada...");
        repetir = false;
    }

} while (repetir);

Console.WriteLine("FIM.");