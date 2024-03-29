﻿using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mehmet Sıddık Albayrak";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyton";
            kurs3.Egitmen = "Melike Simay Albayrak";
            kurs3.IzlenmeOrani = 54;

            //Console.WriteLine(kurs1.KursAdi +":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + " - %" + kurs.IzlenmeOrani );
            }
            

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
