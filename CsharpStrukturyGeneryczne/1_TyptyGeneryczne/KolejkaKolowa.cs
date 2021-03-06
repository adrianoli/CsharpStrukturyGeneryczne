﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TyptyGeneryczne
{
    public class KolejkaKolowa<T>
    {
        private T[] bufor;
        private int poczatekBufor;
        private int koniecBufor;

        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1];
            poczatekBufor = 0;
            koniecBufor = 0;
        }

        public void Zapisz(T wartosc)
        {
            bufor[koniecBufor] = wartosc;
            koniecBufor = (koniecBufor + 1) % bufor.Length;

            if(koniecBufor == poczatekBufor)
            {
                poczatekBufor = (poczatekBufor + 1) % bufor.Length;
            }
        }

        public T Czytaj()
        {
            var wynik = bufor[poczatekBufor];
            poczatekBufor = (poczatekBufor + 1) % bufor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }

        public bool JestPusty
        {
            get
            {
                return koniecBufor == poczatekBufor;
            }
        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufor + 1) % bufor.Length == poczatekBufor;
            }
        }
    }
}
