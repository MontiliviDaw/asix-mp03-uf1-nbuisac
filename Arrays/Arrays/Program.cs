// Arrays
Random r = new Random();
int[] temperatura;
int mes;

int[] diesPerMes = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

Console.WriteLine(diesPerMes.Length);
for (int i = 0; i < diesPerMes.Length; i++) {
    Console.WriteLine($"El mes { i + 1, 2 } te {diesPerMes[i]} dies");
}

Console.Write("A quin numero de mes estem -> ");
mes = Convert.ToInt32(Console.ReadLine());

temperatura = new int[diesPerMes[mes - 1]];
Console.WriteLine("N'he creat " + temperatura.Length);

// Generem les temperatures
for(int i = 0; i < temperatura.Length; i++) {
    temperatura[i] = r.Next(10, 30);
}

// Mostrem les tempertarures
for(int i = 0; i < temperatura.Length;i++) {
    Console.Write($"{temperatura[i], 3}");
}
Console.WriteLine();

int maxima, minima;

minima = 30;
maxima = 0;
minima = int.MaxValue;
maxima = int.MinValue;
minima = maxima = temperatura[0];
for (int i = 0; i < temperatura.Length ; i++) {
    if (temperatura[i] < minima) {
        minima = temperatura[i];
    }
    if (temperatura[i] > maxima) {
        maxima = temperatura[i];
    }
}
Console.WriteLine($"minima = {minima} / maxima = {maxima}");

Console.ReadKey(true);


