internal class Program {
    private static void Main(string[] args) {
        Queue<int[,]> cua = new Queue<int[,]>();
        int[,] posicio;
        Random r = new Random();

        for(int i = 0; i < 10; i++) {
            posicio = new int[1, 2];
            posicio[0, 0] = r.Next(100) + 1;
            posicio[0, 1] = r.Next(100) + 1;
            cua.Enqueue(posicio);
        }
        foreach(var valor in cua) {
            Console.WriteLine($"{valor[0,0]}, {valor[0,1]}");
        }
        Console.ReadKey();
    }
}