using System.Diagnostics;
using System.Drawing;

namespace serp {
    internal class Program {
        static int incX = 0, incY = 0;
        static bool fi = false;
        private static void Main(string[] args) {
            int alt, ample;
            int posX, posY;

            

            Inicialitza(out ample, out alt, out posX, out posY);
            incX = 0; incY = 0;
            Console.Clear();
            Console.SetCursorPosition(posX, posY);
            Console.Write("#");
            Thread llegeix = new Thread(LlegirTecla);
            llegeix.Start();

            while (! fi) {

                //                Console.SetCursorPosition(posX, posY);
                //                Console.Write(" ");
//                Console.Clear();
                posX = posX + incX;
                posY = posY + incY;
                if (posX < 0) posX = ample - 1;
                else if (posX >= ample) posX = 0;
                if (posY < 0) posY = alt- 1;
                else if (posY >= alt) posY = 0;
                Console.SetCursorPosition(posX, posY);
                Console.Write("#");
                Thread.Sleep(100);
            }
            Console.ReadKey(true);


        }
        static void LlegirTecla() {
            ConsoleKeyInfo tecla;

            tecla = Console.ReadKey(true);
            while (tecla.Key != ConsoleKey.Escape) {
                if (tecla.Key == ConsoleKey.UpArrow) {
                    incX = 0; incY = -1;
                }
                else if (tecla.Key == ConsoleKey.DownArrow) {
                    incX = 0; incY = 1;
                }
                else if (tecla.Key == ConsoleKey.LeftArrow) {
                    incX = -1; incY = 0;
                }
                else if (tecla.Key == ConsoleKey.RightArrow) {
                    incX = 1; incY = 0;
                }
                tecla = Console.ReadKey(true);
            }
            fi = true;
            }
        static void Inicialitza(out int ample, out int alt, out int x, out int y) {
            ample = Console.WindowWidth;
            alt = Console.WindowHeight;
            x = ample / 2 - 1;
            y = alt / 2 - 1;

        }
    }

}