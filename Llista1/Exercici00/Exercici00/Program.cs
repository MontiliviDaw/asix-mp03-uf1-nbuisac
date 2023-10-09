// Solució d'una equació de primer grau
// ax + b = 0
// declarem les variables
double a, b, x;
// demanem els valors a i b a l'usuari
Console.WriteLine("Anem a  resoldre una equació de 1r grau ax + b = 0");
Console.Write("Entra el valor de a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el valor de b: "); 
b = Convert.ToDouble(Console.ReadLine());
// calculem el valor de x
x = -b / a;
// donem la resposta
Console.WriteLine("La solucio és x = " + x);