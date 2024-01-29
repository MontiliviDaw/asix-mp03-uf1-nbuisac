// Llista 4 - Exercici 20
int num1, num2, multiple, gran;

Console.Write("Entra un número enter positiu -> ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra un altre número enter positiu -> ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) { 
    multiple = num1;
}
else { 
    multiple = num2; 
}
gran = multiple;
while (multiple % num1 != 0 || multiple % num2 != 0)
{
    multiple = multiple + gran;
}
Console.WriteLine($"mcm({num1}, {num2}) = {multiple}");