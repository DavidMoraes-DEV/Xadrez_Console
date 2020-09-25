using Xadrez.tabuleiro;

namespace Xadrez.xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int Linha)
        {
            this.Coluna = coluna;
            this.Linha = Linha;
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
    }
}
