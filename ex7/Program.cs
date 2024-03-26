/*
Construa um programa para tratamento de erros para uma calculadora simples de números inteiros (adição, multiplicação e divisão).
O objetivo é ter uma calculadora funcional que retorne uma string com o seguinte padrão: 16 + 51 = 67, quando fornecidos os argumentos 16, 51 e +.
Calculatora.Calcular(16, 51, "+");

Exceções
Qualquer valor diferente deve gerar ArgumentOutOfRangeException 
Valores vazios ArgumentException 
Null ArgumentNullException 
Divisão por zero
*/
using System;
internal class Program
{
    private static void Main(string[] args)
    {

        Calculator c = new Calculator();
        int a = c.Calcular("5", "3", '*');
        Console.WriteLine(a);

    }
}

class Calculator
{

    private int result, num1, num2;
    public Calculator()
    {

    }

    public int Calcular(string primaryNumber, string secondaryNumber, char operation)
    {

        if (!int.TryParse(primaryNumber, out this.num1) || !int.TryParse(secondaryNumber, out this.num2))
        {
            throw new ArgumentOutOfRangeException("O VALOR " + primaryNumber + "OU" + secondaryNumber + " NÃO SÃO UM NÚMERO.");
        }

        if (num1 == null || num2 == null || operation == null)
        {
            throw new ArgumentException("NENHUM VALOR DEVE SER NULO.");
        }

        if (this.num2 == 0)
        {
            throw new DivideByZeroException("VOLTA PARA O FUNDAMENTAL, ANIMAL!");
        }

        switch (operation)
        {
            case '+':
                this.result = num1 + num2;
                break;
            case '*':
                this.result = num1 * num2;
                break;
            case '/':
                this.result = num1 / num2;
                break;
            default:
                throw new ArgumentException("OPERAÇÃO INEXISTENTE.");
                break;
        }
        return this.result;
    }
}