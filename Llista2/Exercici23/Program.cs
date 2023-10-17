// See https://aka.ms/new-console-template for more information
char lletraMinuscula, lletraMajuscula;
Console.Write("Escriu una lletra en minúscula -> ");
lletraMinuscula = Convert.ToChar(Console.ReadLine());
Console.WriteLine(lletraMinuscula);
lletraMajuscula = (char)(lletraMinuscula - 'a' + 'A');
Console.WriteLine(lletraMajuscula);
lletraMinuscula++;
Console.WriteLine(lletraMinuscula);
lletraMajuscula = Char.ToUpper(lletraMinuscula);
Console.WriteLine(lletraMajuscula);



