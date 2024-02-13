int numero;

Console.Write("Entra un valor enter positiu -> ");
numero = Convert.ToInt32(Console.ReadLine());
while(numero <= 0) {
    Console.Write("ERROR: Entra un valor enter positiu -> ");
    numero = Convert.ToInt32(Console.ReadLine());
}
numero++;
while (numero % 13 != 0 || numero % 5 != 0) {
    numero++;
}
Console.WriteLine(numero);