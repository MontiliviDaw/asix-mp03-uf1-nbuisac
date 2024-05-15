internal class Program {
    private static void Main(string[] args) {
        StreamReader f1, f2;
        int encerts;
        string l1, l2;
        f1 = new StreamReader(@"c:\asix\mp03\f1.txt");
        f2 = new StreamReader(@"c:\asix\mp03\f2.txt");
        encerts = 0;
        while (f1.EndOfStream == false && f2.EndOfStream == false) {
            l1 = f1.ReadLine();
            l2 = f2.ReadLine();
            if (l1 == l2) {
                encerts++;
            }
        }
        Console.WriteLine($"N'has encertat {encerts}");

    }
}