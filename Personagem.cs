namespace RPG
{
    internal class Personagem
    {
        private string? nome;
        private string? classe;
        private int? vida;
        private int? forca;
        private int? magia;
        private int? agilidade;

        public Personagem(string? nome, string? classe, int? vida, int? forca, int? magia, int? agilidade)
        {
            this.nome = nome;
            this.classe = classe;
            this.vida = 0;
            this.forca = 0;
            this.magia = 0;
            this.agilidade = 0;
        }

    }

}