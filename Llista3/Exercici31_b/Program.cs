using System.Data;
using System.IO.Pipes;
using System.Security.AccessControl;

int ddmmaaaa, dd, mm, aaaa;
bool dataValida;

Console.Write("Entra una data per validar -> ");
ddmmaaaa = Convert.ToInt32(Console.ReadLine());
dd = ddmmaaaa / 1000000;
aaaa = ddmmaaaa % 10000;
mm = ddmmaaaa / 10000 % 100;

Console.WriteLine("Dia: " + dd);
Console.WriteLine("Mes: " + mm);
Console.WriteLine("Any: " + aaaa);

dataValida = false;
switch (mm) {
    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
        if (dd >= 1 && dd <= 31) {
            dataValida = true;
        }
        break;
    case 4: case 6: case 9: case 11:
        if (dd >= 1 && dd <= 30) {
            dataValida = true;
        }
        break;
    case 2: 
        if (aaaa % 400 == 0 || (aaaa % 4 == 0 && aaaa % 100 != 0)) {
            // any de traspàs
            if (dd >= 1 && dd <= 29)  {
                dataValida = true;
            }
        } else {
            // any de no traspàs
            if (dd >= 1 && dd <= 28)  {
                dataValida = true;
            }
        }
        break;
}
if (dataValida == true) {
    Console.WriteLine("Data correcta");
} else {
    Console.WriteLine("Data incorrecta");
}