using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

internal class Program {
    private static void Main(string[] args) {

        string cs = @"server=localhost;userid=daw;password=daw;database=daw";

        var con = new MySqlConnection(cs);
        con.Open();

        Console.WriteLine($"MySQL version : {con.ServerVersion}");

        string sql = "SELECT * FROM employees where employee_id > @valor order by last_name";

        var cmd = new MySqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@valor", 20);
        cmd.Prepare();
        MySqlDataReader rdr = cmd.ExecuteReader();

        Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),-10}");

        while (rdr.Read()) {
            Console.WriteLine("{0,4} {1,-10} {2,-10}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2));
        }
        Console.ReadKey();















        /*
            StreamReader fitxer;
                string linia;

                fitxer = new StreamReader(@"c:\ASIX\prova.txt");

                // anem a llegir linia a linia (si no és buit)
                while (!fitxer.EndOfStream) {
                    // LLEGEIXO
                    linia = fitxer.ReadLine();
                    string[] dades = linia.Split(":");
                    // TRACTO LES DADES
                    Console.WriteLine(dades[0]);
                    Console.WriteLine(dades[2]);
                    Console.WriteLine(dades[5]);
                }
                fitxer.Close();
        */
    }
}