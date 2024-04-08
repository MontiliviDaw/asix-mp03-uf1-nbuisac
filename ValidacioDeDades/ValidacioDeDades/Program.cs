using System.Reflection.PortableExecutable;

internal class Program {
    private static void Main(string[] args) {
        

        string nom, cognom, dni, telefon, dataNaixement, email;
        int edat;
        Titol("Validem Dades");

        nom = DemanaString("Nom");
        nom = Transforma(nom);
        cognom = Transforma(DemanaString("Cognom"));

        do {
            dni = DemanaString("DNI");
        } while (! ValidDNI(dni));
        email = DemanaString("email");
        if(ValidEmail(email)) { Console.WriteLine("Ok DNI"); }
        else { Console.WriteLine("KO DNI"); }
        dataNaixement = DemanaString("Data de Naixement");
        if (ValidDataNaixement(dataNaixement)) {
            Console.WriteLine("Ok Data Naixement");
        } else { Console.WriteLine("KO Data Naixement")}


        Console.ReadKey();
    }

    static bool ValidDataNaixement(string dia) {
        DateTime dt;

        return DateTime.TryParse(dia, out dt);
    }
    static bool ValidEmail(string email) {
        bool valid = true;
        string usuari, domini;
        
        if (! email.Contains("@")) {
            valid = false;
        } else {
            email = email.ToLower();
            usuari = email.Substring(0, email.IndexOf("@"));
            if (usuari.Length < 3) {
                valid = false;
            } else {
                for(int i = 0;i < usuari.Length;i++) {
                    if ((usuari[i] < '0' || usuari[i] > '9') && 
                        (usuari[i] <'a' || usuari[i] > 'z')) {
                        valid = false;
                    }
                }
            }
            if (valid) {
                domini = email.Substring(email.IndexOf("@") + 1);
                if (! domini.Contains(".")) {
                    valid = false;
                }
                else {
                    string esquerra, dreta;
                    esquerra = domini.Substring(0, domini.IndexOf("."));
                    dreta = domini.Substring(domini.IndexOf(".") + 1);
                    if (esquerra.Length < 3) {
                        valid = false;
                    } else {
                        for( int i = 0; i < esquerra.Length;i++) {
                            if (esquerra[i] < 'a' || esquerra[i] > 'z')
                                valid = false;
                        }
                        if (dreta != "cat" || dreta != "com" || dreta != "es") {
                            valid = false;
                        }
                    }
                }
            }







        }
        return valid;
    }

    static bool ValidTelefon(string telefon) {
        bool valid = true;

        if (telefon.Length != 9) {
            valid = false;
        }
        else {
            for(int i = 0; i < telefon.Length; i++) {
                if (telefon[i] < '0' || telefon[i] > '9') {
                    valid = false;
                }
            }
        }
        return valid;
    }
    static bool ValidDNI(string dni) {
        string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";
        bool valid = true;

        valid = dni.Length == 9;
        if (valid) {
            for (int i = 0; i < 8; i++) {
                if (dni[i] < '0' || dni[i] > '9') {
                    valid = false;
                }
            }
        }
        if (valid) {
            if (lletres[Convert.ToInt32(dni.Substring(0, 8)) % 23] != dni.ToUpper()[8])
                valid = false;
        }
        return valid;
    }
    static string Transforma(string m) {
        return m.Substring(0, 1).ToUpper() + m.Substring(1).ToLower();
    }
    static string DemanaString(string que) {
        string dada;
        do {
            Console.Write($"{que}: ");
            dada = Console.ReadLine();
        } while (dada.Trim() == "");
        return dada.Trim();
    }

    static void Titol(string missatge) {
        Console.WriteLine(missatge);
        Console.WriteLine("=".PadRight(missatge.Length, '='));
    }
}