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
        do {
            email = DemanaString("email");
        } while (!ValidEmail(email));
        do {
            dataNaixement = DemanaString("Data de Naixement");
        } while (!ValidDataNaixement(dataNaixement));


        Console.ReadKey();
    }

    static bool ValidDataNaixement(string dia) {
        DateTime dt;
        return DateTime.TryParse(dia, out dt);
    }
    static bool ValidEmail(string em) {
        bool valid = true;
        string usuari, domini,esquerra, dreta;

        em = em.ToLower();
        usuari = em.Substring(0, em.IndexOf('@'));
        domini = em.Substring(em.IndexOf('@') + 1);
        if (usuari.Length < 3) valid = false;
        else {
            for(int i = 0; i < usuari.Length; i++) {
                if (((usuari[i] < '0' || usuari[i] > '9') &&
                     (usuari[i] < 'a' || usuari[i] > 'z'))) {
                    valid = false;
                }
            }
        }
        if (valid) {
            esquerra = domini.Substring(0, domini.IndexOf('.'));
            dreta = domini.Substring(domini.IndexOf('.') + 1);
            if (esquerra.Length < 3) valid = false;
            else {
                int i = 0;
                while (i < esquerra.Length && valid) {
                    if (esquerra[i] < 'a' || esquerra[i] > 'z')
                        valid = false;
                    i++;
                }
                if (dreta != "com" && dreta != "cat" && dreta != "es")
                    valid = false;
            }
        }
        return valid;
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