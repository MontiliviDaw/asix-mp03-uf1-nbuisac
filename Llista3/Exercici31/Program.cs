using System.Data;

int ddmmaaaa, dd, mm, aaaa;
bool dataValida;

Console.Write("Entra una data en format DDMMAAAA -> ");
ddmmaaaa = Convert.ToInt32(Console.ReadLine());
aaaa = ddmmaaaa % 10000;
dd = ddmmaaaa / 1000000;
mm = ddmmaaaa / 10000 % 100;
Console.WriteLine($"Dia: {dd}");
Console.WriteLine($"Mes: {mm}");
Console.WriteLine($"Any: {aaaa}");
dataValida = false;
// Validem el mes
if (mm >= 1 && mm <= 12) {
    // mes correcte, validem dia
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
                // Si és de traspàs
                if (dd >= 1 && dd <= 29) {
                    dataValida = true;
                }
            } else {
                // No és de traspàs
                if (dd >= 1 && dd <= 28) {
                    dataValida = true;
                }
            }
            break;
    }
}
if (dataValida == true) {
    Console.WriteLine("Data Correcta");
} else {
    Console.WriteLine("Data incorrecta");
}











