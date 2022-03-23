using tabuleiro;
using xadrez;

namespace xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QtdMovimentos == 0;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudeste
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //esquerda
            pos.DefinirValores(Posicao.linha , Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //noroeste
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            //Jogada especial roque
            if(QtdMovimentos == 0 && !partida.Xeque)
            {
                // jogada especial, roque pequeno
                Posicao posT1 = new Posicao(Posicao.linha, Posicao.coluna + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna + 2);
                    if(Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna + 2] = true;
                    }
                }

                // jogada especial, roque grande
                Posicao posT2 = new Posicao(Posicao.linha, Posicao.coluna - 4);
                if (TesteTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna - 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna - 2);
                    Posicao p3 = new Posicao(Posicao.linha, Posicao.coluna - 3);
                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null && Tabuleiro.peca(p3) == null)
                    {
                        mat[Posicao.linha, Posicao.coluna - 2] = true;
                    }
                }

            }


            return mat;
        }
    }
}

