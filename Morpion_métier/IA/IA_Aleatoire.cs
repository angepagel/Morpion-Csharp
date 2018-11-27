﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion_métier
{
    /// <summary>
    /// Cette IA joue aléatoirement dans les cases libres.
    /// </summary>
    public class IA_Aleatoire : IA
    {

        public void Jouer(PlateauRestreint plateau)
        {

            List<Case> casesLibres = new List<Case>();
            int i = 0;
            
            // On stocke toutes les cases libres dans un array.
            for (int caseX = 0; caseX < 3; caseX++)
            {
                for (int caseY = 0; caseY < 3; caseY++)
                {
                    if (plateau.GetCase(caseX, caseY).EstMarquee() == null)
                    {
                        casesLibres[i] = plateau.GetCase(caseX, caseY);
                        i++;
                    }
                }
            }

            // On mélange cette liste.
            this.Shuffle(casesLibres);

            // On prend le premier index de cette liste, qui sera la case jouée.
            Case caseJouee = casesLibres[0];

        }

        /// <summary>
        /// Mélange une liste.
        /// https://stackoverflow.com/questions/273313/randomize-a-listt
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private void Shuffle<T>(IList<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
