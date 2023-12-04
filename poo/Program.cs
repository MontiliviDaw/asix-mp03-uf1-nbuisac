using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace poo;

class Program
{
    static void Main(string[] args)
    {
        DataMeva ddd;
        ddd = new DataMeva(31, 12, 2023);
        Console.WriteLine(ddd);
        ddd.IncrementaDia();
        Console.WriteLine(ddd);

        ddd = new DataMeva(15062023);
        Console.WriteLine(ddd);
        ddd.IncrementaDia();
        Console.WriteLine(ddd);
        ddd.IncrementaDies(17);
        Console.WriteLine(ddd);
        
        ddd = new DataMeva("29022024");
        Console.WriteLine(ddd);
        ddd.IncrementaDia();
        Console.WriteLine(ddd);
        
        Console.WriteLine("Tot bé");

    }
}

class DataMeva {
    private int dd;
    private int mm;
    private int aaaa;

    public DataMeva(int dia, int mes, int any) {
        if (DataValida(dia, mes, any)) {
            dd = dia; 
            mm = mes;
            aaaa = any;
        } else {
            throw new Exception("Format incorrecte");
        }
    }
    public DataMeva(int ddmmaaaa)
        : this (ddmmaaaa/ 1000000, ddmmaaaa / 10000 % 100, ddmmaaaa % 10000) 
    {
    }
    public DataMeva(string ddmmaaaa)
        : this (Convert.ToInt32(ddmmaaaa)) 
    {
    }
    private bool EsDeTraspas(int aaaa) {
        return (aaaa % 400 == 0 || (aaaa % 4 == 0 && aaaa % 100 != 0));
    }

    public void IncrementaDies(int q) {
        while (q > 0) {
            IncrementaDia();
            q--;
        }
    }
    public void IncrementaDia() {
        if (mm == 1 || mm == 3 || mm == 5 || mm == 7 || mm == 8 || mm == 10 || mm == 12) {
            dd++;
            if (dd > 31) {
                mm++;
                dd = 1;
                if (mm > 12) {
                    mm = 1;
                    aaaa++;
                }
            }
        } else if (mm == 4 || mm == 6 || mm == 9 || mm == 11) {
            dd++;
            if (dd > 30) {
                mm++;
                dd = 1;
            }
        } else {
            dd++;
            if (dd > 29 || (dd > 28 && ! EsDeTraspas(aaaa))) {
                dd = 1;
                mm++;
            }
        }

    }
    private bool DataValida(int dd, int mm, int aaaa) {
        bool dataValida = false;
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
        return dataValida;
    }

    public override string  ToString(){
        return dd + "/" + mm + "/" + aaaa;
    }
}