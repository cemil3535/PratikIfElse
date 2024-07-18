// See https://aka.ms/new-console-template for more information

// Kullaninican sayi alnimasi.
Console.Write("Lutfen bir sayi giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

// Kullanicidan alinan sayinin 10'dan buyuk,kucuk,esit olup olmadiginin kontrol edilmesi.
if (sayi > 10)
{
    Console.WriteLine("Girilen sayi 10'dan buyuktur.");
}
else if (sayi < 10)
{
    Console.WriteLine("Girilen sayi 10'dan kucuktur.");
}
else
{
    Console.WriteLine("Girilen sayi 10'a esittir.");
}

// Kullanicidan alinan sayinin tek mi?, cift mi? oldugunun kontrol edilmesi.
if (sayi % 2 ==0)
{
    Console.WriteLine("Girilen sayi cifttir.");
}
else
{
    Console.WriteLine("Girilen sayi tektir.");
}


