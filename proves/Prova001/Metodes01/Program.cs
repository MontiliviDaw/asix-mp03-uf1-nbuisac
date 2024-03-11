void MostraMissatge(string m, bool titol) {
    Console.WriteLine(m);
    if (titol)
        Console.WriteLine("".PadLeft(m.Length, '='));
}
int Maxim(int a, int b) {
    int major;
    if (a > b)
        major = a;
    else
        major = b;
    return major;
}
string nom;
MostraMissatge("Entra el teu nom -> ", false);
nom = Console.ReadLine();
MostraMissatge("Hola " + nom, true);
MostraMissatge("Hello, World!", true);
MostraMissatge("Ja estem acabant!!!", false);
Console.WriteLine(Maxim(10, 3));
Console.WriteLine(Maxim(100, -2));
MostraMissatge("El major entre 12 i 4 és " + Maxim(12, 4), false);
