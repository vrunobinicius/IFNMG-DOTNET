/*OBS.:
PARA EXECUTAR ESSE CÓDIGO É PRECISO ENVIAR 
1° PALAVRA BASE E em 2° A LISTA APÓS O 'dotnet run'.

EXEMPLO: dotnet amor roma mora ramo

A PRIMEIRA PALAVRA É A PALAVA BASE (amor) E AS DEMAIS FAZEM PARTE DA LISTA DE ANAGRAMAS.
*/ 

internal class Program
{
    private static void Main(string[] args)
    {
        string? palava_base = null;
        if (args.Length > 0)
        {
            palava_base = args[0];
        }

        List<string> anagramas = new List<string>();

        for (int i = 1; i < args.Length; i++)
        {
            anagramas.Add(args[i]);
        }

        Anagramas an = new Anagramas();
        List<string>? res = an.anagramas(palava_base, anagramas);

        if (res != null)
        {
            if (res.Count != 0)
            {
                Console.WriteLine("Anagramas");
                foreach (string item in res)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Nenhum anagrama");
            }
        }
    }
}

class Anagramas
{
    private List<string> resAnagramas;
    public Anagramas()
    {
        resAnagramas = new List<string>();
    }

    public List<string>? anagramas(string? palavra_base, List<string>? palavras)
    {
        if (palavra_base == null)
        {
            Console.WriteLine("Palavra base não pode ser vazia");
            return null;
        }

        if (palavras == null || palavras.Count == 0)
        {
            Console.WriteLine("Nenhum anagrama");
            return null;
        }

        bool isOneWord = false;
        foreach (string item in palavras)
        {
            if (palavra_base.Length == item.Length && palavra_base.ToUpper() != item.ToUpper())
            {
                for (int i = 0; i < palavra_base.Length; i++)
                {
                    if (palavra_base.ToUpper().Contains(Char.ToUpper(item[i])))
                    {
                        isOneWord = true;
                    }
                    else
                    {
                        isOneWord = false;
                    }
                }
            }

            if (isOneWord)
            {
                ResAnagramas.Add(item);
                isOneWord = false;
            }
        }

        return ResAnagramas;
    }

    public List<string> ResAnagramas => resAnagramas;
}
