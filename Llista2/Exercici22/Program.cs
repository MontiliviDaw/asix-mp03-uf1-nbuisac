// 22.Demanar una lletra i escriure el seu codi ASCII.
char caracter;
int numero;
Console.Write("Entra una lletra -> ");
caracter = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"El caracter {caracter} és el codi {(int) caracter}");
numero = caracter;
Console.WriteLine($"El caracter {caracter} és el codi {numero}");

