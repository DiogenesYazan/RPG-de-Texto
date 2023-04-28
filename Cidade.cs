using System;

namespace RPG
{
    class Cidade
    {
        private string nome;
        private int populacao;

        public Cidade(string nome, int populacao)
        {
            this.nome = nome;
            this.populacao = populacao;
        }

        public Cidade()
        {
        }

        public void VisitarLojas()
        {
            Console.WriteLine("Você está visitando as lojas da cidade de {0}...", nome);
            // Implemente aqui a lógica para interagir com as lojas da cidade
        }

        public void InteragirComMoradores()
        {
            Console.WriteLine("Você está interagindo com os moradores da cidade de {0}...", nome);
            // Implemente aqui a lógica para interagir com os moradores da cidade
        }

        public void InteragirComCidade()
        {
            Console.WriteLine("Bem-vindo à cidade de {0}! O que você gostaria de fazer?", nome);
            Console.WriteLine("1. Visitar as lojas");
            Console.WriteLine("2. Interagir com os moradores");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    VisitarLojas();
                    break;
                case 2:
                    InteragirComMoradores();
                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }
        }
    }
}
