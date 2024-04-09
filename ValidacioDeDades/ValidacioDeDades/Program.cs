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

}