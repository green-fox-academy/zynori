﻿using System;
using System.Collections.Generic;

namespace dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            foreach (var item in DominoSorting(dominoes))
            {
                Console.WriteLine($"{item.GetValues()[0]}, {item.GetValues()[1]}");
            }

            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        public static List<Domino> DominoSorting(List<Domino> dominoes)
        {
            int[] currentDomino = new int[2];
            List<Domino> orderedDominoes = new List<Domino>();
            orderedDominoes.Add(dominoes[0]);
            currentDomino = dominoes[0].GetValues();

            for (int i = 0; i < dominoes.Count - 1; i++)
            {
                for (int j = 1;  j < dominoes.Count;  j++)
                {
                    if (dominoes[j].GetValues()[0] == currentDomino[1])
                    {
                        orderedDominoes.Add(dominoes[j]);
                        currentDomino = dominoes[j].GetValues();
                    }
                }
            }

            return orderedDominoes;
        }
    }
}
// You have the list of Dominoes
// Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
// Create a function to write the dominous to the console in the following format
// eg: [2, 4], [4, 3], [3, 5] ...