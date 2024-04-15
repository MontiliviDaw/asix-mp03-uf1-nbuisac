using System.Diagnostics;
using System.Drawing;

internal class Program {
    private static void Main(string[] args) {
        int alt, ample;
        int posX, posY;
        ConsoleKeyInfo tecla;

        Inicialitza(out ample, out alt, out posX, out posY);
        Console.Clear();
        Console.SetCursorPosition(posX, posY);
        Console.Write("#");

        tecla = Console.ReadKey();
        while (tecla.Key != ConsoleKey.Escape) {
            if (tecla.Key == ConsoleKey.UpArrow) {
                posY--;
                if (posY < 0) posY = alt - 1;
            }
            else if (tecla.Key == ConsoleKey.DownArrow) {
                posY = (posY + 1) % alt;
            }
            else if (tecla.Key == ConsoleKey.LeftArrow) {
                posX--;
                if (posX < 0) posX = ample - 1;
            }
            else if (tecla.Key == ConsoleKey.RightArrow) {
                posX = (posX + 1) % ample;
            }
            Console.SetCursorPosition(posX, posY);
            Console.Write("#");
            tecla = Console.ReadKey();
        }
        Console.ReadKey(true);


    }
    static void Inicialitza(out int ample, out int alt, out int x, out int y) {
        ample = Console.WindowWidth;
        alt = Console.WindowHeight;
        x = ample / 2 - 1;
        y = alt / 2 - 1;

    }
}