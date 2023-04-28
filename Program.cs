using System.Threading;
using static RPG.Cidade;


//Um projeto de um RPG de Texto insirado em um projeto que meu amigo Rafah fez em java.
//Tambem inspirado em D&D e Diablo.
namespace RPG
{
    class Program
    {

public static void TypeWriter(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50); // espera 50 milissegundos entre cada caractere
        }
    }
    static void Main(string[] args)
        {

            string asciiArt = @"
             /$$$$$$$  /$$$$$$$   /$$$$$$         /$$$$$$  /$$   /$$  /$$$$$$  /$$$$$$$  /$$$$$$$ 
            | $$__  $$| $$__  $$ /$$__  $$       /$$__  $$| $$  | $$ /$$__  $$| $$__  $$| $$__  $$
            | $$  \ $$| $$  \ $$| $$  \__/      | $$  \__/| $$  | $$| $$  \ $$| $$  \ $$| $$  \ $$
            | $$$$$$$/| $$$$$$$/| $$ /$$$$      |  $$$$$$ | $$$$$$$$| $$$$$$$$| $$$$$$$/| $$$$$$$/
            | $$__  $$| $$____/ | $$|_  $$       \____  $$| $$__  $$| $$__  $$| $$__  $$| $$____/ 
            | $$  \ $$| $$      | $$  \ $$       /$$  \ $$| $$  | $$| $$  | $$| $$  \ $$| $$      
            | $$  | $$| $$      |  $$$$$$/      |  $$$$$$/| $$  | $$| $$  | $$| $$  | $$| $$      
            |__/  |__/|__/       \______/        \______/ |__/  |__/|__/  |__/|__/  |__/|__/      

            By: Diogenes Yazan

            ";

            string asciiArt_Fim = @"
             /$$$$$$$$ /$$                     /$$$$$$$                     /$$$$$                              
            | $$_____/|__/                    | $$__  $$                   |__  $$                              
            | $$       /$$ /$$$$$$/$$$$       | $$  \ $$  /$$$$$$             | $$  /$$$$$$   /$$$$$$   /$$$$$$ 
            | $$$$$   | $$| $$_  $$_  $$      | $$  | $$ /$$__  $$            | $$ /$$__  $$ /$$__  $$ /$$__  $$
            | $$__/   | $$| $$ \ $$ \ $$      | $$  | $$| $$$$$$$$       /$$  | $$| $$  \ $$| $$  \ $$| $$  \ $$
            | $$      | $$| $$ | $$ | $$      | $$  | $$| $$_____/      | $$  | $$| $$  | $$| $$  | $$| $$  | $$
            | $$      | $$| $$ | $$ | $$      | $$$$$$$/|  $$$$$$$      |  $$$$$$/|  $$$$$$/|  $$$$$$$|  $$$$$$/
            |__/      |__/|__/ |__/ |__/      |_______/  \_______/       \______/  \______/  \____  $$ \______/ 
                                                                                             /$$  \ $$          
                                                                                            |  $$$$$$/          
                                                                                             \______/               
            By: Diogenes Yazan
            ";

            // Apresentação do jogo
            Console.WriteLine(asciiArt);
            TypeWriter("Bem-vindo ao RPG Sharp, um projeto feito em C# baseado em RPG de Texto!");

            // Criação do personagem
            TypeWriter("\nCrie seu personagem:");

            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            TypeWriter("\nClasse \nAssassino \nBarbaro \nNecromante \nPaladino \nMago \n");
            string classe = Console.ReadLine();
            //Dando um valor inicial à variável.
            int? vida = 0;
            int? forca = 0;
            int? magia = 0;
            int? agilidade = 0;
            //Usar switch & case é bem melhor que if else. Nesse caso uso para definir o valor de cada variável de acordo com a classe que for escolhida.
            switch (classe)
            {
                case "Assassino":
                    vida = 20;
                    forca = 10;
                    magia = 2;
                    agilidade = 18;
                    break;
                case "Barbaro":
                    vida = 15;
                    forca = 20;
                    magia = 1;
                    agilidade = 8;
                    break;
                case "Necromante":
                    vida = 12;
                    forca = 5;
                    magia = 15;
                    agilidade = 10;
                    break;
                case "Paladino":
                    vida = 20;
                    forca = 13;
                    magia = 2;
                    agilidade = 15;
                    break;
                case "Mago":
                    vida = 15;
                    forca = 6;
                    magia = 16;
                    agilidade = 8;
                    break;
                default:
                    Console.WriteLine("Classe inválida!");
                    break;
            }

            Personagem jogador = new Personagem(nome, classe, vida, forca, magia, agilidade);

            //Mostrar a classe e cada atributo que escolheu.
            Console.WriteLine("\nVocê escolheu a classe {0}.", classe);
            Console.WriteLine("\nVida {0}.", vida);
            Console.WriteLine("\nforça {0}.", forca);
            Console.WriteLine("\nMagia {0}.", magia);
            Console.WriteLine("\nAgilidade {0}.", agilidade);


            // Introdução à história
            Console.WriteLine("\nVocê acorda em um lugar desconhecido, cercado por escuridão Mas vê uma cidade a frente");
            Console.WriteLine("Você não sabe onde está nem como chegou aqui, mas uma coisa é certa: você precisa sair deste lugar.");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(asciiArt);
            TypeWriter("\nTutorial:");
            TypeWriter("\nVocê terá muitas alternativas para escolher e principalmente o DADO.");
            TypeWriter("\nO dado determina muito sua sorte para acertar ou errar uma ação.");



            // Opções iniciais
            Console.WriteLine("\nEscolha sua primeira ação:");
            Console.WriteLine("1. Explorar o ambiente");
            Console.WriteLine("2. Procurar por itens");
            Console.WriteLine("3. ir para cidade");

            Cidade cidade = new Cidade();

            // Processamento da escolha do usuário
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    // Implementação da ação "explorar o ambiente"
                    Console.WriteLine("\nVocê percebe que está em uma floresta bastante fechada e estranha.");
                    TypeWriter("\nRolando dado para decidir seu caminho:");
                    bool escapou = Dado.JogarD20();
                    if (escapou)
                    {
                        TypeWriter("\nVocê acertou!");
                        Console.WriteLine("\nVocê consegue sair da floresta e vai até a cidade...");
                        //chamar a função cidade.
                        cidade.InteragirComCidade();

                    }
                    else
                    {
                        Console.WriteLine("Você errou...");
                        TypeWriter("\nVocê Morreu por um urso selvagem que apareceu");
                        TypeWriter("\nAqui é tipo Dark Souls Lek");
                        Console.WriteLine(asciiArt_Fim);
                    }
                    break;
                case 2:
                    // Implementação da ação "procurar por itens"
                    TypeWriter("\nSó tem pedra aqui, quer pra que? Tá Doidão?");
                    break;
                case 3:
                    // Implementação da ação "cidade"
                    cidade.InteragirComCidade();

                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }
        }

    }
}