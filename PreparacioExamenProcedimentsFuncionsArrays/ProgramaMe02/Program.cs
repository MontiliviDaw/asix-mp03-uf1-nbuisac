internal class Program {
    private static void Main(string[] args) {
        string[] places;
        int totals, linies;
        Console.Write("Quantes linies entraras ? ");
        linies = Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < linies; j++) {
            places = Console.ReadLine().Split(" ");
            int suma = 0;
            for (int i = 1; i < places.Length; i++) {
                int q = Convert.ToInt32(places[i]);
                suma += q;
            }
            Console.WriteLine((Convert.ToInt32(places[0]) - suma));
        }

    }
}