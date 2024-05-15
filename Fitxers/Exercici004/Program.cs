internal class Program {
    private static void Main(string[] args) {
        StreamReader fEntrada;
        StreamWriter fSortida;
        char cc, c1, c2;
        bool introMig = false;
        int n;
        c1 = ' ';
        fEntrada = new StreamReader(@"C:\asix\mp03\prova.txt");
        fSortida = new StreamWriter(@"C:\asix\mp03\enciptat.txt");
        n = 0;
        while (! fEntrada.EndOfStream) {
            cc = (char) fEntrada.Read();
            if (cc != 10 && cc != 13) {
                n++;
                if (n % 2 == 0) {
                    c2 = cc;
                    fSortida.Write(c2);
                    if (introMig) {
                        fSortida.WriteLine();
                        introMig = false;
                    }
                    fSortida.Write(c1);
                }
                else {
                    c1 = cc;
                }
            }
            else
                if (cc == 13) {
                    if (n % 2 == 0) fSortida.WriteLine();
                    else introMig = true;
                }
        }
        if (n % 2 == 1) {
            if (introMig) fSortida.WriteLine();
            fSortida.Write(c1);
        }
        fEntrada.Close();
        fSortida.Close();


    }
}