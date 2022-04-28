using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgoritmalarLab
{
    class Program
    {
        static int pow(int _base, int exponent)
        {
            if (exponent < 1) return 1;
            return _base * pow(_base, exponent - 1);
        }
        static int bit = 0;
        static int adet = 0;
        static int say(uint sayi)
        {

            if (bit > 32) return adet;
            if ((sayi & 1) == 1) { adet++; bit++; return say(sayi >> 1); }
            else { bit++; return say(sayi >> 1); }
        }
        static bool AsalMi(int sayi)
        {
            bool bl=true;
            for (int i = 2; i < sayi/2; i++)
            {
                if (sayi % i == 0) return bl=false;
            }
            return bl;
        } 
        
        
        
        static void Main(string[] args)
        {
            //                                          1 or x = 1
            //                                          0 or x = x
            //                                          1 and x = x
            //                                          0 and x = 0
            #region 32 bitlik sayı 1 ler 0, 0 lar 1 yapılsın
            /*
            uint a = 1;
            uint b = 1;
            uint c = 1;
            uint d = 0xfffffffe;
            Console.WriteLine(a);
            for (int i = 0; i < 32; i++)
            {
                if ((a & b) == 0)
                {
                    a = a | c;
                }
                else { a = a & d; }
                b = b << 1;
                c = c << 1;
                d = d << 1;
                d++;
            }
            Console.WriteLine();
            */
            #endregion
            #region 32 bitlik sayı rotate edilsin 
            /*
            uint a = 0xc0000000;
            uint b = 0x80000000;
            Console.WriteLine(a);
            Console.WriteLine(Convert.ToString(a,toBase:2));
            Console.WriteLine(Convert.ToString(b,toBase:2));
            if ((a & b) != 0)
            {
                a = a << 1;
                a++;
            }
            else { a= a<< 1; }
            Console.WriteLine(Convert.ToString(a, toBase: 2));
            Console.WriteLine(a);
            */
            #endregion
            #region ilk 5 biti 1 arttırma 
            /*
            uint a = 0xefffffff;
            Console.WriteLine(a);
            Console.WriteLine("a: {0}",Convert.ToString(a, toBase: 2));
            uint b = a - a & 0xf8000000;
            b = b >> 27;
            b++;
            b = b << 27;
            a = 0x07ffffff;
            a = a | b;
            Console.WriteLine(a);
            Console.WriteLine("a: {0}", Convert.ToString(a, toBase: 2));
            */
            #endregion
            #region 1 leri sayan kod 
            /*
            uint a = 12;  
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((a & 0x1) == 1) { count++; a = a >> 1; }
                else a = a >> 1;
            }
            Console.WriteLine(count);
            */
            #endregion
            #region taşma kontrolu
            /*
            uint a = 0xffffffff;
            int b = (int)a;
            a++; a--;
            if (a == b) Console.WriteLine("tasma yok");
            else Console.WriteLine("tasma var");
            */
            #endregion
            #region string ifadeyi convert etme
            /*
            string st1 = "123456";
            int st2 = 0;
            
            for (int i = 0; i < st1.Length; i++)
            {
                byte bt = 0;
                bt = (byte)(st1[i] - '0');
                st2 = (st2 * 10 + bt);
            }
            Console.WriteLine(st2);
            */
            #endregion
            #region subset n eleman
            /*
            int[] sayilar = { 12, 14,23 };
            
            int n = sayilar.Length;
            int[] x = new int[n + 1];
            int s = n-1;
            int adet = 0;

            while (x[n] != 1)
            {
                adet++;
                for (int i = 0; i < n; i++)
                {
                    if (x[i] == 1) Console.Write(i + " ");// Console.Write(sayilar[i]+" ");
                }
                Console.WriteLine();
                x[0]++;
                for (int i = 0; i < n; i++)
                {
                    if (x[i] == s) { x[i] = 0; x[i + 1]++; }
                }
            }
           */
            #endregion
            #region 2 lik tabanda yazdırma 
            /*
            uint a = 1;
            uint b = 0x80000000;
            for (int i = 0; i < 32; i++)
            {
                if ((a & b) == 1) Console.Write(1);
                else Console.Write(0);
                b = b >> 1;
            }
            */
            #endregion
            #region 1 leri say recursive
            /*
            uint a = 1;
            Console.WriteLine(say(a));
            */
            #endregion
            #region Pi sayisi
            //3+ 4/234 -4/456 +....
            /*
            double pi = 3;
            int t = 1;
            for (int i = 2; i < 500; i+=2)
            {
                pi = pi + (double)4 / (i * (i + 1) * (i + 2)) * t;
                t = t * -1;
            }
            Console.WriteLine(pi);
            */
            #endregion
            #region Dinamik gelen sayıların 5 e bölümünden kalan 
            /*
            int[,] Q = new int[5, 2];
            Q[0, 0] = 0; Q[0, 1] = 1;
            Q[1, 0] =  0; Q[1, 1] = 1;
            Q[2, 0] = 0; Q[2, 1] = 1;
            Q[3, 0] = 0; Q[3, 1] = 1;
            Q[4, 0] = 0; Q[4, 1] = 1;

            string ss = "102";
            int kalan = 0;
            for (int i = 0; i < ss.Length; i++)
            {
                kalan = Q[kalan, (byte)ss[i]-'0'];
            }
            Console.WriteLine(kalan);
            */
            #endregion
            #region (Karesi sayılar) asal çarpanları çarpımı kendsini veren
            /*
            int sayi = 42;
            int sonuc = 1;
            for (int i = 2; i < sayi/2+1; i++)
            {
                if (sayi % i == 0) 
                {
                    if (AsalMi(i)) sonuc = sonuc * i;
                }
            }
            if (sayi == sonuc) Console.WriteLine("karesiz sayı");
            else Console.WriteLine("değil");
            */
            #endregion

        }
    }
}
