Console.Write("Bir cümle giriniz: ");
string metin = Console.ReadLine();

int kelimesayisi = metin.Split(' ').Length;
Console.WriteLine(kelimesayisi);
Console.ReadLine();