internal class Program {
    private static void Main(string[] args) {
        StreamReader fe;
        StreamWriter fs;
        string nom, nomMenor, nomMajor;
        int edat, edatMajor, edatMenor;
        int sumaEdats = 0, quants = 0;
        double mitjana;

        fe = new StreamReader(@"c:\ASIX\MP03\Llista.txt");
        if (!fe.EndOfStream) {
            nomMajor = fe.ReadLine();
            edatMajor = Convert.ToInt32(fe.ReadLine());
            nomMenor = nomMajor;
            edatMenor = edatMajor;


            while (!fe.EndOfStream) {
                nom = fe.ReadLine();
                edat = Convert.ToInt32(fe.ReadLine());
                quants++;
                sumaEdats = sumaEdats + edat;
                if (edat > edatMajor) {
                    edatMajor = edat;
                    nomMajor = nom;
                }
                if (edat < edatMenor) {
                    edatMenor = edat;
                    nomMenor = nom;
                }
                Console.WriteLine($"En/la {nom,10} te {edat,2} anys");
            }
            fs = new StreamWriter(@"C:\asix\mp03\Resum.txt", true);
            mitjana = sumaEdats / (double) quants;
            fs.WriteLine($"El major és {nomMajor} i te {edatMajor} anys");
            fs.WriteLine($"El menor és {nomMenor} i te {edatMenor} anys");
            fs.WriteLine($"la mitjana d'edats és {mitjana}");
            fs.Close();
            Console.WriteLine($"El major és {nomMajor} i te {edatMajor} anys");
            Console.WriteLine($"El menor és {nomMenor} i te {edatMenor} anys");
            Console.WriteLine($"la mitjana d'edats és {mitjana}");
        }
        fe.Close();
    }
}