internal class Program {
    private static void Main(string[] args) {
        StreamReader fe;
        string paraula;
        int q = 0;
        string linia;

        Console.Write("Entra la paraula a buscar -> ");
        paraula = Console.ReadLine().Trim().ToLower();

        fe = new StreamReader(@"C:\asix\mp03\poema.txt");
        while ( ! fe.EndOfStream ) {
            linia = fe.ReadLine();
            if (linia.ToLower().Contains(paraula)) {
                EscriuLinia(linia, paraula);
            }
        }
        fe.Close();

    }
    static void EscriuLinia(string linia, string paraula) {
        int primera, actual;
        ConsoleColor color;

        color = Console.ForegroundColor;

        actual = 0;
        primera = linia.ToLower().IndexOf(paraula.ToLower(), actual);
        while (primera >= 0) {
            if (primera > actual) {
                Console.Write(linia.Substring(actual, primera - actual));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(linia.Substring(primera, paraula.Length));
                Console.ForegroundColor = color;
                actual = primera + paraula.Length;
            }
            else {
                Console.Write(linia.Substring(primera, paraula.Length));
                actual = primera + paraula.Length;
            }
            primera = linia.ToLower().IndexOf(paraula.ToLower(), actual);
        }
        Console.WriteLine(linia.Substring(actual));

    }
}