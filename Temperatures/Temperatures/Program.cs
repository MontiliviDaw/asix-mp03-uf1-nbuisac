internal class Program {
    private static void Main(string[] args) {
        Random r = new Random();
        int[] temperatura;
        int tMax, tMin;
        double tMitjana;

        int dies;
        int mes;
        Console.Write("Quants dies té el mes? ");
        dies = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El mes te {dies} dies");

        temperatura = new int[dies];
        // Demanem temperatures
        for(int i = 0;  i < temperatura.Length; i++) {
            // Console.Write($"Entra la temperatura del dia {i + 1} -> ");
            temperatura[i] = r.Next(20, 31);
        }
        tMax = -1;
        tMin = 100;
        tMitjana = 0;
        // Mostrem temperatures entrades
        for(int i = 0; i < temperatura.Length;i++) {
            Console.WriteLine($"El dia {i + 1} ha fet {temperatura[i]} graus");
            tMitjana = tMitjana + temperatura[i];
            if (temperatura[i] > tMax) {
                tMax = temperatura[i];
            }
            if (temperatura[i] < tMin) {
                tMin = temperatura[i];
            }
        }
        Console.WriteLine($"La temperatura mínima ha estat {tMin}");
        Console.WriteLine($"La temperatura màxima ha estat {tMax}");
        Console.WriteLine($"La temperatura mitjana ha estat {tMitjana / temperatura.Length}");




    }
}