// Llista 6 - Exercici 2
using System.Data.SqlTypes;

string nc1, nc2;
int pos1_1, pos1_2, pos2_1, pos2_2;
int comparo;
Console.Write("Entra un nom amb dos cognoms -> ");
nc1 = Console.ReadLine().Trim();
Console.Write("Entra un altre nom amb dos cognoms -> ");
nc2 = Console.ReadLine().Trim();

// Posicions del primer nom/cognoms
pos1_1 = nc1.IndexOf(' ');
pos2_1 = nc1.IndexOf(' ', pos1_1 + 1);
// Posicions del segon nom/cognoms
pos1_2 = nc2.IndexOf(' ');
pos2_2 = nc2.IndexOf(' ', pos1_2 + 1);

Console.WriteLine(nc1.Substring(0, pos1_1)); // mostra el nom
Console.WriteLine(nc1.Substring(pos1_1 + 1, pos2_1 - pos1_1 - 1));
Console.WriteLine(nc1.Substring(pos2_1 + 1, nc1.Length - pos2_1 - 1));
Console.WriteLine(nc2.Substring(0, pos1_2)); // mostra el nom
Console.WriteLine(nc2.Substring(pos1_2 + 1, pos2_2 - pos1_2 - 1));
Console.WriteLine(nc2.Substring(pos2_2 + 1, nc2.Length - pos2_2 - 1));

comparo = nc1.ToUpper().Substring(pos1_1 + 1, pos2_1 - pos1_1 - 1) // primer primer cognom
          .CompareTo(
          nc2.ToUpper().Substring(pos1_2 + 1, pos2_2 - pos1_2 - 1));  // segon primer cognom

Console.WriteLine(comparo);

if  (comparo == 0) {
    // Comparo 2ns cognoms
    comparo = nc1.ToUpper().Substring(pos2_1 + 1, nc1.Length - pos2_1 - 1) // primer segon cognom
              .CompareTo(
              nc2.ToUpper().Substring(pos2_2 + 1, nc2.Length - pos2_2 - 1));  // segon segon cognom
    if (comparo == 0) {
        // comparo noms
        comparo = nc1.ToUpper().Substring(0, pos1_1) // primer nom
                  .CompareTo(
                  nc2.ToUpper().Substring(0, pos1_2));  // segon nom
    }
}

if (comparo < 0) {
    Console.WriteLine(nc1);
    Console.WriteLine(nc2);
}
else if (comparo > 0) {
    Console.WriteLine(nc2);
    Console.WriteLine(nc1);
}
else {
    Console.WriteLine("Iguals");
    Console.WriteLine(nc1);
}