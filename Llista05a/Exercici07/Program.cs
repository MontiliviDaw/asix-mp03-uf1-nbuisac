// Llista 5a - Exercici 7
// Mostra la diferència entre el major i el menor
int gran, petit, numero, diferencia;
Console.Write("Entra un numero (0 per acabar) -> ");
numero = Convert.ToInt32(Console.ReadLine());
petit = gran = numero;
while (numero != 0) {
    // tracto les dades
    if (numero > gran) {
        gran = numero;
    } else if (numero < petit) {
        petit = numero;
    }
    // preparo la següent iteració
    Console.Write("Entra un numero (0 per acabar) -> ");
    numero = Convert.ToInt32(Console.ReadLine());
}
diferencia = gran - petit;
Console.WriteLine($"{gran} - {petit} = {diferencia}");