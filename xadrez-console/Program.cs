﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
                       try
                       {
                           Tabuleiro tab = new Tabuleiro(8, 8);

                           tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                           tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 5));
                           tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 1));
                           


                           Tela.imprimirTabuleiro(tab);
                       }
                       catch(TabuleiroExcepition e)
                       {
                           Console.WriteLine(e.Message);
                       }
           
            Console.ReadLine();
            }
    }
}
