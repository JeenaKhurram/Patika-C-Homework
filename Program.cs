﻿using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve islemli atama
            int x = 3;
            int y = 3;
            y= y+2;
            Console.WriteLine(y);
            y+= 2 ;

            Console.WriteLine(y);
            y/= 1;
            Console.WriteLine(y);
                   x *= 2;
        System.Console.WriteLine(x);
        // mantıksal Operatörler
        // ||, %%, !
        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted)
            System.Console.WriteLine("Perfect!");
        if (isSuccess || isCompleted)
            System.Console.WriteLine("Great!");
        if (isSuccess && !isCompleted)
            System.Console.WriteLine("fine! :)");

        int a = 3;
        int b = 4;
        bool sonuc =a<b;

        System.Console.WriteLine(sonuc);
        sonuc = a>b;
        System.Console.WriteLine(sonuc);
        sonuc = a>=b;
        System.Console.WriteLine(sonuc);
        sonuc = a<=b;
        System.Console.WriteLine(sonuc);    
        sonuc = a==b;
        System.Console.WriteLine(sonuc);
        sonuc = a!=b;   
        System.Console.WriteLine(sonuc);

        int sayı1 = 10;
        int sayı2 = 5;
        int sonuc1 = sayı1/sayı2;
        System.Console.WriteLine(sonuc1);
        sonuc1 = sayı1*sayı2;
        System.Console.WriteLine(sonuc1);
        sonuc1 = sayı1+sayı2;
        System.Console.WriteLine(sonuc1);
        sonuc1 = sayı1++;
        System.Console.WriteLine(sonuc1);

        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);




        }
    }
}

