BinaryWriter fitxerBinari;
StreamWriter fitxerText;
int i;
Console.WriteLine("Generem i escrivim");
fitxerBinari = new BinaryWriter(File.OpenWrite(@"c:\asix\prova.dat"));
fitxerText = new StreamWriter(@"c:\asix\prova.txt");
for (i = 0; i < 3000; i++) {
    fitxerBinari.Write(i);
    fitxerBinari.Write($"Hola {i}");
    fitxerText.WriteLine(i);
    fitxerText.WriteLine($"Hola {i}");
    Console.Write($"{i,4}");
}
fitxerBinari.Close();
fitxerText.Close();