using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }


        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tabuleiro.peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            if(Cor == Cor.Branco)
            {
                pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.DefinirValores(Posicao.linha - 2, Posicao.coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QtdMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
            }
            else
            {
                pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.DefinirValores(Posicao.linha + 2, Posicao.coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QtdMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
            }
            return mat;

        }

    }
}
