using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //try
            //{
            //    Console.WriteLine("Reqemleri daxil et");
            //    string numstr1 = Console.ReadLine();
            //    string numstr2 = Console.ReadLine();
            //    string numstr3 = Console.ReadLine();
            //    int num1 = int.Parse(numstr1);
            //    int num2 = int.Parse(numstr2);
            //    int num3 = int.Parse(numstr3);

            //    Bignums(num1, num2, num3);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}

            #endregion

            #region task2
            //try
            //{
            //    Console.WriteLine("Ilk ededi daxil edin :");
            //    string numstr1 = Console.ReadLine();
            //    int num1 = int.Parse(numstr1);
            //    Console.WriteLine("Ikinci ededi daxil edin :");
            //    string numstr2 = Console.ReadLine();
            //    int num2 = int.Parse(numstr2);
            //    Console.WriteLine("Ucuncu ededi daxil edin :");
            //    string numstr3 = Console.ReadLine();
            //    int num3 = int.Parse(numstr3);
            //    Console.WriteLine("Dorduncu ededi daxil edin :");
            //    string numstr4 = Console.ReadLine();
            //    int num4 = int.Parse(numstr4);
            //    Console.WriteLine("Besinci ededi daxil edin :");
            //    string numstr5 = Console.ReadLine();
            //    int num5 = int.Parse(numstr5);

            //    Result(num1, num2, num3, num4, num5);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}
            #endregion

            #region task3
            //try
            //{
            //    Console.WriteLine("duzbucaqlinin enini qeyd edin: ");
            //    string a = Console.ReadLine();
            //    int a1 = int.Parse(a);
            //    Console.WriteLine("duzbucaqlinin uzunlugunu qeyd edin: ");
            //    string b = Console.ReadLine();
            //    int b1 = int.Parse(b);

            //    Result(a1, b1);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}
            #endregion

            #region task4
            //try
            //{
            //    Console.WriteLine("Eded daxil edin: ");
            //    string numstr = Console.ReadLine();
            //    int num = int.Parse(numstr);
            //    Sum(num);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}
            #endregion

            #region task5
            //try
            //{
            //    Console.WriteLine("eded daxil edin: ");
            //    string numstr = Console.ReadLine();
            //    int num = int.Parse(numstr);
            //    Result(num);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez");
            //}
            #endregion

            #region task6

            //try
            //{
            //    Console.WriteLine("Eded daxil edin: ");
            //    string numstr = Console.ReadLine();
            //    int num = int.Parse(numstr);
            //    Result(num);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}
            #endregion

            #region task7
            //try
            //{
            //    Console.WriteLine("Imtahan neticenizi daxil edin: ");
            //    string numstr = Console.ReadLine();
            //    int num = int.Parse(numstr);
            //    Mark(num);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil edile bilmez..");
            //}
            #endregion

            #region task8
            //try
            //{
            //    Console.WriteLine("Ilk ededi daxil edin: ");
            //    string numstr1 = Console.ReadLine();
            //    int num1 = int.Parse(numstr1);
            //    Console.WriteLine("Ikinci ededi daxil edin: ");
            //    string numstr2 = Console.ReadLine();
            //    int num2 = int.Parse(numstr2);
            //    Sum(num1, num2);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("herf daxil edile bilmez");
            //}
            #endregion

            #region task9
            //try
            //{
            //    Console.WriteLine("Ededi daxil edin: ");
            //    string numstr1 = Console.ReadLine();
            //    int eded = int.Parse(numstr1);

            //    Console.WriteLine("Quvveti daxil edin: ");
            //    string numstr2 = Console.ReadLine();
            //    int quvvet = int.Parse(numstr2);
            //    Result(eded, quvvet);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Herf daxil etmek olmaz..");
            //}
            #endregion


        }

        #region task1
        //static void Bignums(int a, int b, int c)
        //{

        //    if (a > b && a > c)
        //    {
        //        Console.WriteLine("a boyuk");
        //    }
        //    else if (b > a && b > c)
        //    {
        //        Console.WriteLine("b boyuk");
        //    }
        //    else if (c > b && c > a)
        //    {
        //        Console.WriteLine("c boyuk");
        //    }
        //    else
        //    {
        //        Console.WriteLine("beraberlik var");
        //    }
        //}
        #endregion

        #region task2
        //static void Result(int num1, int num2, int num3, int num4, int num5)
        //{
        //    int average;
        //    average = (num1 + num2 + num3 + num4 + num5) / 5;
        //    Console.WriteLine(average);
        //}
        #endregion


        #region task3
        //static void Result(int a1, int b1)
        //{
        //    int sahe = 0;
        //    int perimetr = 0;

        //    sahe = a1 * b1;
        //    perimetr = (a1 + b1) * 2;
        //    Console.WriteLine("Duzbucaqlinin sahesi " + sahe + "perimetri ise " + perimetr + "-dir");
        //}
        #endregion

        #region task4
        //static void Sum(int num)
        //{

        //    int count = 0;
        //    if (num > 1)
        //    {
        //        for (int i = 1; i < num; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    if (count > 2)
        //    {
        //        Console.WriteLine("Daxil edilen eded murekkebdir..");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Daxil edilen eded sadedir...");
        //    }
        //}
        #endregion

        #region task5
        //static void Result(int num)
        //{
        //    int count = 0;
        //    while (num > 1)
        //    {
        //        num = num / 10;
        //        count++;
        //    }
        //    Console.WriteLine(count);

        //}
        #endregion

        #region task6
        //static void Result(int num)
        //{
        //    if (num > 0)
        //    {
        //        if (num % 21 == 0)
        //        {
        //            Console.WriteLine("Eded hem 3-e hem de 7-ye bolunur..");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Eded 3-e ve 7-ye bolunmur..");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Dogru eded daxil edin!");
        //    }
        //}
        #endregion

        #region task7
        //static void Mark(int num)
        //{
        //    if(num>=0 && num <= 100)
        //    {
        //        if (num >= 91 && num <= 100)
        //        {
        //            Console.WriteLine("A");
        //        }else if (num >= 81 && num <= 90)
        //        {
        //            Console.WriteLine("B");
        //        }else if (num >= 71 && num <= 80)
        //        {
        //            Console.WriteLine("C");
        //        }else if (num >= 61 && num <= 70)
        //        {
        //            Console.WriteLine("D");
        //        }else if(num >= 51 && num <= 60)
        //        {
        //            Console.WriteLine("D");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Kesildiniz :)");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Dogru deyer daxil et..");
        //    }
        //}
        #endregion

        #region task8
        //static void Sum(int num1,int num2)
        //{
        //    int min;
        //    int max;
        //    int sum = 0;
        //    if(num1 > num2)
        //    {
        //        min = num2;
        //        max = num1;
        //    }
        //    else
        //    {
        //        min = num1;
        //        max = num2;
        //    }
        //    for (int i = min; i <= max; i++)
        //    {
        //        sum += i;

        //    }
        //    Console.WriteLine("Cemi " + sum);
        //}
        #endregion

        #region task9
        //static void Result(int eded,int quvvet)
        //{
        //    if(eded>1 && quvvet > 1)
        //    {
        //        int result = 1;
        //        for (int i = 1; i <= quvvet; i++)
        //        {
        //            result = result * eded;
        //        }
        //        Console.WriteLine(result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Duzgun deyer daxil et: ");
        //    }
        //}
        #endregion



    }
}

