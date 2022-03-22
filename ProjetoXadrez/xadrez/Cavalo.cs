using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Cavalo: Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "C";
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

            //acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 2);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //direita
            pos.DefinirValores(Posicao.linha - 2, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudeste
            pos.DefinirValores(Posicao.linha - 2, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 2);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 2);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //esquerda
            pos.DefinirValores(Posicao.linha + 2, Posicao.coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //noroeste
            pos.DefinirValores(Posicao.linha + 2, Posicao.coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 2);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
