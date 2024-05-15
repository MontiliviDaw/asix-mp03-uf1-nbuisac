internal class Program {
    private static void Main(string[] args) {
        string vocals = "aeiouAEIOUàèòÀÈÒáéíóúÁÉÍÓÚïÏüÜ";
        char caracter;
        StreamReader fitxer;
        StreamWriter fitxerSortida;

        fitxer = new StreamReader(@"c:\asix\mp03\prova.txt");
        fitxerSortida = new StreamWriter(@"c:\asix\mp03\senseVocals.txt", false);
        while (! fitxer.EndOfStream) {
            caracter = (char)fitxer.Read();
            if (! vocals.Contains(caracter)) {
                fitxerSortida.Write(caracter);
            } else
                fitxerSortida.Write('_');
        }
        fitxer.Close();
        fitxerSortida.Close();
    }
}