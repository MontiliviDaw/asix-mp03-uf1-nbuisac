internal class Program {
    private static void Main(string[] args) {
        int opcio;
        int[] dades;
        int quants;

        MostraMenu();
        opcio = DemanaOpcio();
        dades = new int[6];
        while (opcio != 0) {
            // Tractem les dades
            switch (opcio) {
                case 1:
                    OmplirDades(dades);
                    break;
                case 2:
                    MostraDades(dades);
                    break;
                case 3:
                    quants = DemanaQuants();
                    Mostar(dades, quants);
                    break;
                case 4:
                    Console.WriteLine($"Has escollit {opcio}");
                    break;
                case 5:
                    Console.WriteLine($"Has escollit {opcio}");
                    break;
                case 6:
                    Console.WriteLine($"Has escollit {opcio}");
                    break;

            }
            Console.ReadKey();
            // Preparem la següent iteracio
            MostraMenu();
            opcio = DemanaOpcio();
        }

    }

    static void OmplirDades(int[] v) {
        Random r = new Random();
        bool[] posats;
        int numero;
        
        posats = new bool[50];
        int i = 0;
        while (i < v.Length) {
            numero = r.Next(1, 50);
            if (posats[numero] == false) {
                posats[numero] = true;
                v[i] = numero;
                i++;
            }
        }
        Array.Sort(v);
    }
    static void MostraDades(int[] v) {
        for(int i = 0; i < v.Length; i++) {
            Console.WriteLine($"{v[i], 2}");
        }
    }
    static int DemanaOpcio() {
        int o;
        bool ok;
        ok = int.TryParse(Console.ReadLine(), out o);
        while (o < 0 || o > 6 || ok == false) {
            Console.WriteLine("Opció incorrecta.");
            ok = int.TryParse(Console.ReadLine(), out o);
        };

        
        return o;
    }

    static void MostraMenu() {
        Console.Clear();
        Console.WriteLine("1.- Omple Dades");
        Console.WriteLine("2.- Mostra Dades");
        Console.WriteLine("3.- Omple Dades");
        Console.WriteLine("4.- Mostra Dades");
        Console.WriteLine("5.- Omple Dades");
        Console.WriteLine("6.- Mostra Dades");
        Console.WriteLine("\n0.- Sortir");
    }
}