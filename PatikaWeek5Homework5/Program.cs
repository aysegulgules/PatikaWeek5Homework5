Console.WriteLine("Lütfen bir sayı giriniz..:");

numberGo:
try 
{
 double number = double.Parse(Console.ReadLine());
    Console.WriteLine("Girdiğiniz sayının karesi..:"+ Math.Pow(number,2));//Girilen sayının karesi yazdırılıyor.
}
catch (FormatException ) //girilen değerin formatı uygun olmadığında çalışır.
{ 
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    goto numberGo;
}

