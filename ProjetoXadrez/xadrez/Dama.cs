using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Dama:Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "D";
        }


        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //esquerda
            pos.DefinirValores(Posicao.linha, Posicao.coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha, pos.coluna - 1);
            }

            //direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha, pos.coluna + 1);
            }

            ////acima
            //pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            //while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            //{
            //    mat[pos.linha, pos.coluna] = true;
            //    if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
            //    {
            //        break;
            //    }
            //    pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            //}

            // acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha - 1, pos.coluna);
            }

            //abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha + 1, pos.coluna);
            }

            

            


            //NO
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha - 1, pos.coluna - 1);
            }

            //NE
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha - 1, pos.coluna + 1);
            }

            //SE
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha + 1, pos.coluna + 1);
            }

            //SO
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha + 1, pos.coluna - 1);
            }


            return mat;
        }
    }
}
