int comptador;

Console.Write("Quantes vegades vols repetir? ");
comptador = Convert.ToInt32(Console.ReadLine());
while (comptador < 10)
{
    Console.WriteLine("Aquesta es una linia" + comptador);
    comptador++;
}


Console.ReadLine();