using System;
namespace IntegerToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz.Girdiğiniz sayı kadara Sayı Giriniz...:");
            int count=int.Parse(Console.ReadLine());
            List<int> lists=new List<int>();
            int value;
            for (int i = 1; i <=count; i++)
            {
                Console.Write(i+". Sayıyı Giriniz...:");
                int number=int.Parse(Console.ReadLine());
                lists.Add(number);
            }
            for (int k = 0; k < count; k+=2)
            {
                if (lists[k]==lists[k+1])
                {
                    value= lists[k]*lists[k+1];
                    value*=value;
                    Console.Write(value+" ");
                }
                else
                {
                     Console.Write(lists[k]+lists[k+1]+" ");
                }
            }
        }
    }
}
