using System;
using System.Linq;
using System.Collections.Generic;


/// <summary>
/// Genericke medody ktere umoznuji tisknout pocitatelne kolekce, slovniky a genericka funkce na matematickou modifikaci pocitatelne kolekce.
/// Cviceni k C# 7 - Seznamy, https://www.youtube.com/watch?v=j3e53tPB464
/// </summary>
namespace Pata_ClassLibrary_extation
{

        public static class Rozsireni
        {
            /// <summary>
            /// vypise obsah pocitatelneho typu (pole, seznam, cokoliv..)
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="nazev"></param>
            /// <param name="text"></param>
            public static void TiskniTo<T>(this IEnumerable<T> nazev, string text = "") //tisk pomoci foreach a vstup je univerzalni pocitatelny typ (pole, seznam, cokoliv..)
            {
                Console.ForegroundColor = ConsoleColor.Green; //nastavi barvu textu na zelenou
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Gray; //vrati barvu textu na svetle sedou
                foreach (var i in nazev) //var nebo T - funguje oboje 
                {
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
            /// <summary>
            /// vypise obsah slovniku bez ohledu na typy klicu a hodnot
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="slovnik"></param>
            public static void VypisSlovnik<T>(this Dictionary<T, T> slovnik)
            {
                foreach (var item in slovnik)
                {
                    Console.WriteLine("{0} = {1}", item.Key.ToString(), item.Value.ToString());
                }
            }
        /// <summary>
        /// vypise obsah slovniku kde klic je typu int a hodnoty typu T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="slovnik"></param>
        public static void VypisSlovnik<T>(this Dictionary<int, T> slovnik)
            {
                foreach (var item in slovnik)
                {
                    Console.WriteLine("{0} = {1}", item.Key.ToString(), item.Value.ToString());
                }
            }
        /// <summary>
        /// funkce, ktera ve vstupni kolekci kazdy clen vynasobi dvema
        /// </summary>
        /// <param name="nazev">promenne typu IEnumerable s hodnotami typu int </param>
        /// <returns>List dvojnasobnych hodnot int nez uchovaval vstupni pocitatelna promena</returns>
            public static List<int> VynasobClenyDvema(this IEnumerable<int> nazev)
            {
                List<int> novyList = new List<int>(nazev.Count());
                for (int i = 0; i < nazev.Count(); i++)
                {
                    novyList.Add(nazev.ElementAt(i) * 2);
                }
                return novyList;
            }
        }
    }

