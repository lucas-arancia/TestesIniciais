namespace JogoBiblico;

public static class Program
{
    public static void Main(string[] args)
    {
        ExibirOpcoesdoMenu();

    }

    public static void ExibirLogo()
    {
        Console.WriteLine(@"
        ███████████████████████████████████████████████████████████████
        █─▄▄▄─█▄─██─▄█▄─▄█░▄▄░▄███▄─▄─▀█▄─▄█▄─▄─▀█▄─▄███▄─▄█─▄▄▄─█─▄▄─█
        █─██▀─██─██─███─███▀▄█▀████─▄─▀██─███─▄─▀██─██▀██─██─███▀█─██─█
        █▄▄▄▄▄██▄▄▄▄██▄▄▄█▄▄▄▄▄███▄▄▄▄██▄▄▄█▄▄▄▄██▄▄▄▄▄█▄▄▄█▄▄▄▄▄█▄▄▄▄█
        ███████████████████████████████████████████████████████████████");

        Console.WriteLine();

        string mensagemDeBoasVindas = "Seja bem vindo ao quiz";
        Console.WriteLine(mensagemDeBoasVindas);

    }

    public static void ExibirOpcoesdoMenu()
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para iniciar o Quiz");
        Console.WriteLine("Digite 2 para sair");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                IniciarQuiz();
                break;
            case 2:
                Console.WriteLine("Voce escolheu a opção 2");
                Console.WriteLine("Até mais");
                break;
        }
        Console.WriteLine("Opção Iválida");
        Console.WriteLine("Aperte qualquer tecla para sair");

    }

    public static void IniciarQuiz()
    {
        // primeira pergunta
        int numero = 969;
        Console.Clear();
        Console.Write("1 - Quantos anos viveu Metusalem? ");
        int resposta = Convert.ToInt32(Console.ReadLine());
        if (resposta == numero)
        {
            Console.WriteLine("Parabéns! Você acertou!");
            Console.WriteLine("Aperte qualquer tecla para proxima pergunta");
            Console.ReadKey();
        }

        else if (resposta >= 940 && resposta <= 980)
        {
            Console.WriteLine("Quase!");
            Thread.Sleep(3000);
            SegundaChance();
            Console.WriteLine("Aperte qualquer tecla para proxima pergunta");
            Console.ReadKey();
        }
        else if (resposta >= 920 && resposta <= 939)
        {
            Console.WriteLine("Um pouco longe!");
            Thread.Sleep(3000);
            SegundaChance();
            Console.WriteLine("Aperte qualquer tecla para proxima pergunta");
            Console.ReadKey();
        }
        else if (resposta <= 919)
        {
            Console.WriteLine("Muito longe, volte a ler a biblia!");
            Thread.Sleep(3000);
            SegundaChance();
            Console.WriteLine("Aperte qualquer tecla para proxima pergunta");
            Console.ReadKey();

        }
        //segunda pergunta
        Console.Clear();
        int numero_2 = 6;
        Console.WriteLine("2 - Quantos livros Moises escreveu?");
        int resposta_2 = Convert.ToInt32(Console.ReadLine());
        

        if (resposta_2 == numero_2)
        {
            Console.WriteLine("Parabéns! Você acertou!");
        }
        else
        {
            Console.WriteLine("Errou");

        }
        Console.WriteLine("Aperte qualquer tecla para proxima pergunta");
        Console.ReadKey();

        //terceira pergunta
        Console.Clear();
        Console.WriteLine(@"3 - Quais são os livros?
        A - Gêneses, Êxodo, Levítico, Números, Deuteronômio, Jó
        B - João, Marcos, Matheus, Exodo, Números, 1 Reis
        C - Gêneses, Deuteronomio, Galatas, Josue, Salmos, Jó
        D - João, Atos, Marcos, Números, Gêneses, Josué");


        string resposta_3 = Console.ReadLine();


        if (resposta_3.ToLower() == "a")
        {
            Console.WriteLine("Parabéns! Você acertou!");
            
        }
        else
        {
            Console.WriteLine("Errou!");

        }
        Console.WriteLine("Aperte qualquer tecla para finalizar");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey(); // Bloqueia a tela até que um caractere ou uma tecla de função seja pressionado
        Console.Clear();
        ExibirOpcoesdoMenu();

    }

    public static void SegundaChance()
    {
        int numero = 969;
        char letra = 'C';
        char letra1 = 'c';

        Console.Clear();
        Console.WriteLine("Mais uma chance, digite uma das opções abaixo:");
        Console.WriteLine("A - 979\nB - 960\nC - 969\nD - 959\nE - 950");

        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            if (input.Length == 1 && (input[0] == letra || input[0] == letra1))
            {
                Console.WriteLine("Parabéns! Você acertou!");
                return;
            }
            else if (int.TryParse(input, out int resposta))
            {
                if (resposta == numero)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                    return;
                }
                else if (input.Length != 1 && (input[0] != letra || input[0] != letra1))
                {
                    Console.WriteLine("Errou!");
                    return;
                }
            }
        }
        Console.WriteLine("Errou!");
    }
    
}