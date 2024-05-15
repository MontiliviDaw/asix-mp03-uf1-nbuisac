internal class Program {
    private static void Main(string[] args) {
        StreamReader f1, f2;
        int n1, n2;
        Console.WriteLine("FUSIÓ !!!");
        f1 = new StreamReader(@"C:\asix\mp03\f1.txt");
        f2 = new StreamReader(@"C:\asix\mp03\f2.txt");
        n1 = n2 = 0;
        if (!f1.EndOfStream) n1 = Convert.ToInt32(f1.ReadLine());
        if (!f2.EndOfStream) n2 = Convert.ToInt32(f2.ReadLine());
        
        while (! f1.EndOfStream && ! f2.EndOfStream) {
            if (n1 < n2) {
                Console.WriteLine(n1);
                n1 = Convert.ToInt32(f1.ReadLine());
            } else {
                Console.WriteLine(n2);
                n2 = Convert.ToInt32(f2.ReadLine());
            }
        }
        if (! f2.EndOfStream) {
            if (n1 > n2) {
                while (!f2.EndOfStream && n1 > n2) {
                    Console.WriteLine(n2);
                    n2 = Convert.ToInt32(f2.ReadLine());
                }
            }
            while (!f2.EndOfStream) {
                Console.WriteLine(n2);
                n2 = Convert.ToInt32(f2.ReadLine());
            }
            Console.WriteLine(n2);
        }
        if (!f1.EndOfStream) {
            if (n1 < n2) {
                while (!f1.EndOfStream && n2 > n1) {
                    Console.WriteLine(n1);
                    n1 = Convert.ToInt32(f1.ReadLine());
                }
            }
            Console.WriteLine(n1);
            while (!f1.EndOfStream) {
                Console.WriteLine(n1);
                n1 = Convert.ToInt32(f1.ReadLine());
            }
            Console.WriteLine(n1);
        }
        f1.Close();
        f2.Close();

    }
}