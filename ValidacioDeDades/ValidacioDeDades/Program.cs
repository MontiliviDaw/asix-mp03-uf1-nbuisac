internal class Program {
    private static void Main(string[] args) {
        string nom, cognom, dni, telefon, dataNaixement, email;
        int edat;
        // Titol("Validem Dades");

        nom = DemanaString("Nom");
        nom = Transforma(nom);
        Console.WriteLine(nom);
        cognom = Transforma(DemanaString("Cognom"));
        Console.WriteLine(cognom);

        do {
            dni = DemanaString("DNI");
        } while (! ValidDNI(dni));
        email = DemanaString("email");
        // if(ValidEmail(email)) { Console.WriteLine("Ok DNI"); }
        // else { Console.WriteLine("KO DNI"); }
        dataNaixement = DemanaString("Data de Naixement");
        /* if (ValidDataNaixement(dataNaixement)) {
            Console.WriteLine("Ok Data Naixement");
        } else { Console.WriteLine("KO Data Naixement")}
        */

        Console.ReadKey();
    }

    static bool ValidTelefon(string tel) {
        bool valid = true;
        int i;


        if (tel.Length != 9) {
            valid = false;
        } else {
            i = 0;
            while ( i < 9 && valid) {
                if (tel[i] < '0' || tel[i] > '9')
                    valid = false;
                i++;
            }
        }
        return valid;
    }
    static bool ValidDNI(string dni) {
        bool valid = true;
        string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";
        dni = dni.ToUpper();

        if (dni.Length != 9) {
            valid = false;
        } else {
            for (int i = 0; i < 8; i++) {
                if (dni[i] < '0' || dni[i] > '9') {
                    valid = false;
                }
            }
            if (valid) {
                if (dni[8] != lletres[Convert.ToInt32(dni.Substring(0, 8)) % 23])
                    valid = false;
            }
        }
        return valid;
    }
    static string Transforma(string nom) {
        return nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower(); ;
    }
    static string DemanaString(string que) {
        string dada;

        do {
            Console.Write($"Entra {que}: ");
            dada = Console.ReadLine();
        } while (dada.Trim() == "");
        return dada;
    }

}