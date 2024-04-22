internal class Program {
    private static void Main(string[] args) {
        int opcio;

        MostraMenu();
        opcio = DemanaOpcio();

    }

    static int DemanaOpcio() {
        int o;
        bool ok;
        do {
            ok = int.TryParse(Console.ReadLine(), out o);
        } while (o < 0 || o > 6 || ok == false);

        
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