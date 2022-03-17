using System;
using tabuleiro;
using xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca( new Torre(tab, Cor.Preto) , new Posicao(0, 0));
            tab.ColocarPeca( new Torre(tab, Cor.Preto), new Posicao(1, 9));
            tab.ColocarPeca( new Rei(tab, Cor.Preto), new Posicao(0, 2));

            Tela.mostrarTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
