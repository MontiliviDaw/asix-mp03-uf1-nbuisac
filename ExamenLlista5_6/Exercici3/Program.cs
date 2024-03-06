// Examen cerques - recorreguts i strings - Exercici 3
string pwd;
bool valid = true;
int qMaj, qMin, qDig, qAltres;
pwd = Console.ReadLine();
qMaj = qMin = qDig = qAltres = 0;
if (pwd.Length < 8) {
    valid = false;
} else {
    for (int i = 0; i < pwd.Length; i++) {
        if (pwd[i] >= 'A' && pwd[i] <= 'Z') qMaj++;
        else if (pwd[i] >= 'a' && pwd[i] <= 'z') qMin++;
        else if (pwd[i] >= '0' && pwd[i] <= '9') qDig++;
        else qAltres++;
    }
    if (qMaj == 0 || qMin == 0 || qDig == 0 || qAltres == 0)
        valid = false;
}
if (valid) Console.WriteLine("OK");
else Console.WriteLine("NO OK");
Console.ReadKey();
