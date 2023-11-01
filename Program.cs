using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // HOMEWORK Task - 1
            //IsPrime metodu - parametr olaraq integer value qəbul edir.Göndərilmiş integer dəyərin sadə olub olmadığını qaytarır.Ədəd sadədirsə true,
            //deyilsə false qayıtmalıdır

            Console.WriteLine(IsPrime(9));



            // TASK 2
            //CalcAvg metodu - Göndərilmiş imtahanlar qiyməti siyahısına (integer array) əsasən həmin qiymətlərin ortalamasını qaytaran metod yazın.
            //Main metodunda bu metodu call edib, burdan qayıdan dəyərə əsasən ortalama 60-dan böyükdürsə console-da "Mezun oldunuz" əks halda
            //"Mezun ola bilmediniz" yazısı yazdırın
            int[] arr = { 50, 60, 45, 80, 70 };
            CalcAvg(arr);



        }
        static void CalcAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int value = sum / arr.Length;
            if (value > 60)
            {
                Console.WriteLine(value + " -> Mezun oldunuz");
            }
            else
            {
                Console.WriteLine(value + " -> Mezun ola bilmediniz");
            }
        }
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        //static void GetName(string name)
        //{
        //    Console.WriteLine(name);
        //}
        //static void GetName(string name, string surname)
        //{
        //    Console.WriteLine(name, surname);
        //}

        //static bool IsNumber(int number)
        //{
        //    if (number % 2 == 0)
        //    {
        //        return true;
        //    }
        //    return false;


        //}
        //GetName("Dilara");
        //   Console.WriteLine(IsNumber(5));
        //    if (IsNumber(5))
        //    {
        //        Console.WriteLine("cutdur");
        //    }
        //    else
        //    {
        //        Console.WriteLine("tekdir");
        //    }


    }

}
