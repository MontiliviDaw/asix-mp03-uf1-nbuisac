using System.Diagnostics;
using System.Drawing;

internal class Program {
    static int incX = 0;
    static int incY = 0;
    static bool fi = false;
    private static void Main(string[] args) {
        int alt, ample;
        int posX, posY;
        ConsoleKeyInfo tecla;
        Thread programa;
        ConsoleColor backInicial, foreInicial;

        incX = incY = 0;
        Inicialitza(out ample, out alt, out posX, out posY);
        Console.CursorVisible = false;
        Console.Clear();
        foreInicial = Console.ForegroundColor;
        backInicial = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(posX, posY);
        Console.Write("#");
        programa = new Thread(LlegeixMoviment);
        programa.Start();
        while (! fi) {
//            Console.SetCursorPosition(posX, posY);
//            Console.Write(" ");
            posX = IncrementaX(posX, incX, ample);
            IncrementaY(ref posY, incY, alt);
            Console.SetCursorPosition(posX, posY);
            Console.Write("#");
            Thread.Sleep(200);
        }
        Console.ReadKey(true);
        Console.CursorVisible = true;
        Console.BackgroundColor = backInicial;
        Console.ForegroundColor = foreInicial;
    }

    static void LlegeixMoviment() {
        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey(true);
        while (tecla.Key != ConsoleKey.Escape) {
            if (tecla.Key == ConsoleKey.UpArrow || tecla.Key == ConsoleKey.W) {
                incX = 0;
                incY = -1;
            }
            else if (tecla.Key == ConsoleKey.DownArrow || tecla.Key == ConsoleKey.S) {
                incX = 0;
                incY = 1;
            }
            else if (tecla.Key == ConsoleKey.LeftArrow || tecla.Key == ConsoleKey.A) {
                incX = -1;
                incY = 0;
            }
            else if (tecla.Key == ConsoleKey.RightArrow || tecla.Key == ConsoleKey.D) {
                incX = 1;
                incY = 0;
            }
            tecla = Console.ReadKey(true);
        }
        fi = true;
    }
    static void IncrementaY(ref int y, int increment, int maxim) {
        y = y + increment;
        if (y < 0) y = maxim - 1;
        else if (y >= maxim) y = 0;
    }
    static int IncrementaX(int x, int increment, int maxim) {
        x = x + increment;
        if (x < 0) x = maxim - 1;
        else if (x >= maxim) x = 0;
        return x;

    }
    static void Inicialitza(out int ample, out int alt, out int x, out int y) {
        ample = Console.WindowWidth;
        alt = Console.WindowHeight;
        x = ample / 2 - 1;
        y = alt / 2 - 1;

    }
}