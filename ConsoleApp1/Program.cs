// See https://aka.ms/new-console-template for more information


class Program
{
    static void carregar()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }

    static void correta(string resp, string certa)
    {
        resp = resp.ToLower();
        if (resp == certa)
        {
            Console.WriteLine("Parabéns hein!");
        }
        else
        {
            Console.WriteLine("Nem isso tu sabe?");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao quiz divertido!");

        Console.WriteLine("\nVamos a primeira pergunta");

        Console.WriteLine("Qual a linguagem de programação mais utilizada em 2025?");
        Console.WriteLine("A - COBOL");
        Console.WriteLine("B - Python");
        Console.WriteLine("C - Java");
        Console.WriteLine("D - Javascript");
        carregar();
        Console.WriteLine("\nresponda.");

        string certa = "d";
        string resposta = Console.ReadLine();

        correta(resposta, certa);


        Console.WriteLine("Agora para a última pergunta...");

        Console.WriteLine("Seja a função f(x) = x^3 * e^(2x).");
        Console.WriteLine("Qual o valor da segunda derivada f''(1)?\n");

        Console.WriteLine("A - 40 * e^2");
        Console.WriteLine("B - 22 * e^2");
        Console.WriteLine("C - 30 * e^2");
        Console.WriteLine("D - 50 * e^2\n");

        carregar();
        Console.Write("\nDigite a letra da alternativa correta: ");
        string segresp = Console.ReadLine();
        certa = "b";
        correta(segresp, certa);

        Console.WriteLine("\nObrigado por jogar.");

    }
}



