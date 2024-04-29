
internal class Program {
    private static void Main(string[] args) {
        StreamReader fitxer;
        int q;
        Random r = new Random();

        fitxer = new StreamReader(@"C:\ASIX\MP03\prova.txt");
        while(! fitxer.EndOfStream) {
            q = Convert.ToInt32(fitxer.ReadLine());
            Console.WriteLine("He llegit " + q);
        }
            fitxer.Close();
        // Console.ReadKey();

    }
}