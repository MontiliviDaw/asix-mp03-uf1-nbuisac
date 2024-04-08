// See https://aka.ms/new-console-template for more information
char lletra, anterior, dosAbans;
int quantes = 0;
lletra = Console.ReadKey().KeyChar;
anterior = dosAbans = '0';
while (lletra != '\r' && quantes < 3 && (lletra != 'a' || anterior != 'a' || dosAbans != 'a')) {
    if (lletra == 'a') {
        quantes++;
    } else {
        quantes = 0;
    }
    dosAbans = anterior;
    anterior = lletra;
    lletra = Console.ReadKey().KeyChar;
}
Console.WriteLine();
if (lletra == '\r') {
    Console.WriteLine("No hi ha 3 as");
} else {
    Console.WriteLine("Hem trobat 3 as");
}