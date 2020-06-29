using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._06._29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írj programot, ami kiírja két egész szám négyzetösszegének a 2/3 részét! 
            //A program kérje be a felhasználótól a két egész számot. 
            //A végeredményt 3 tizedes pontossággal írja ki a program!
            Console.Write("Kérem adja meg az első számot! ");
            //double elso = double.Parse(Console.ReadLine());
            int elso = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot! ");
            int masodik = int.Parse(Console.ReadLine());
            double d_elso = Math.Pow((double)elso,2);
            double d_masodik = Math.Pow((double)masodik, 2);
            double osszeg = (d_elso + d_masodik)*2/3;
            Console.WriteLine($"Az {elso} és {masodik} szám négyzetöszzegének a 2/3-ad része: {osszeg}");

            //Írj programot, ami véletlen egész számokkal feltölt egy 15 elemű tömböt, 
            //majd kiírja a konzolra azokat a véletlen  számokat a tömbből, amelyek páratlanok.
            //1.lépés: A tömb létrehozása
            int[] paratlan = new int[15];
            //2.lépés
            Random veletlen = new Random();
            //3.lépés: A tömb feltöltése véletlen számokkal!
            //int i = 100;
            for (int i = 0;i<paratlan.Length;i++)
            {
                paratlan[i] = veletlen.Next(1,101);
                if (paratlan[i] % 2 > 0)
                {
                    Console.Write($"{paratlan[i]} ");
                }              
            }

            Console.ReadKey();
        }
    }
}
