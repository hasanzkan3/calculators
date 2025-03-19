// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        try
        {

            Console.Write("İlk sayiyi giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("İkinci sayiyi giriniz: ");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.Write("Islem cesidi seciniz(+,-,/,*): ");
            char op = char.Parse(Console.ReadLine());
            double sonuc = 0;
            bool HataVar = false;
            switch (op)
            {
                case '+': sonuc = sayi1 + sayi2; break;
                case '-': sonuc = sayi1 - sayi2; break;
                case '*': sonuc = sayi1 * sayi2; break;
                case '/':
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Hata: Sıfıra bölünme hatası!");
                        HataVar = true;
                    }
                    else
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    break;
                default:
                    Console.Write("Geçersiz İşlem Girildi");
                    HataVar = true;
                    break;
            }
            if (!HataVar)
            {
                Console.WriteLine($"Sonuç: {sonuc}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Sayısal değer girilmedi!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Beklenmedik Hata: {ex.Message}");
        }
    }
}
