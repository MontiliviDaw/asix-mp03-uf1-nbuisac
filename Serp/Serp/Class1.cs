using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serp {
    class Class1 {
        static bool prou = false;
        static int ample = 1;
        static int alt = 1;
        static Semaphore semafor = new Semaphore(1, 1);
        private static void Main_(string[] args) {
            Thread t1, t2;
            ConsoleColor c;
            ample = Console.WindowWidth;
            alt = Console.WindowHeight;
            c = Console.ForegroundColor;

            t1 = new Thread(Escriu1);
            t2 = new Thread(Escriu2);
            t2.Start();
            t1.Start();
            Thread.Sleep(10000);
            prou = true;
            Console.ForegroundColor = c;
            Console.ReadKey(true);
        }
        public static void Escriu1() {
            string m = "11";
            int x, y;
            Random r = new Random();
            while (!prou) {
                x = r.Next(ample);
                y = r.Next(alt);
                semafor.WaitOne();
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(m);
                semafor.Release();
                Thread.Sleep(r.Next(100, 1000));
            }
        }
        public static void Escriu2() {
            string m = "22";
            int x, y;
            Random r = new Random();
            while (!prou) {
                x = r.Next(ample);
                y = r.Next(alt);
                semafor.WaitOne();
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(m);
                semafor.Release();
                Thread.Sleep(r.Next(100, 1000));
            }
        }
    }
}
