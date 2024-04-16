using System.Diagnostics;
using System.Drawing;

namespace serp {
    internal class Program {
        static int incX = 0, incY = 0;
        static bool fi = false;
        private static void Main(string[] args) {
            int alt, ample;
            int posX, posY;
            ConsoleColor backAbans, frontAbans;

            backAbans = Console.BackgroundColor;
            frontAbans = Console.ForegroundColor;

            Inicialitza(out ample, out alt, out posX, out posY);
            incX = 0; incY = 0;
            Console.CursorVisible = false;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(posX, posY);
            Console.Write("#");
            Thread llegeix = new Thread(LlegirTecla);
            llegeix.Start();

            while (! fi) {
                // Càlcul de la nova posició
                posX = IncrementaX(posX, incX, ample);
                IncrementaY(ref posY, incY, alt);

                Console.SetCursorPosition(posX, posY);
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.ReadKey(true);
            Console.BackgroundColor = backAbans;
            Console.ForegroundColor = frontAbans;
        }

        public static int IncrementaX(int a, int b, int c) {
            a = a + b;
            if (a < 0) a = c - 1;
            else if (a >= c) a = 0;
            return a;
        }
        public static void IncrementaY(ref int a, int b, int c) {
            a = a + b;
            if (a < 0) a = c - 1;
            else if (a >= c) a = 0;
        }

        static void LlegirTecla() {
            ConsoleKeyInfo tecla;

            tecla = Console.ReadKey(true);
            while (tecla.Key != ConsoleKey.Escape) {
                if (tecla.Key == ConsoleKey.UpArrow || tecla.Key == ConsoleKey.W ) {
                    incX = 0; incY = -1;
                }
                else if (tecla.Key == ConsoleKey.DownArrow || tecla.Key == ConsoleKey.S) {
                    incX = 0; incY = 1;
                }
                else if (tecla.Key == ConsoleKey.LeftArrow || tecla.Key == ConsoleKey.A) {
                    incX = -1; incY = 0;
                }
                else if (tecla.Key == ConsoleKey.RightArrow || tecla.Key == ConsoleKey.D) {
                    incX = 1; incY = 0;
                }
                tecla = Console.ReadKey(true);
            }
            fi = true;
            }
        static void Inicialitza(out int ample, out int alt, out int x, out int y) {
            ample = Console.WindowWidth / 3 * 2;
            alt = Console.WindowHeight;
            x = ample / 2 - 1;
            y = alt / 2 - 1;

        }
    }

}