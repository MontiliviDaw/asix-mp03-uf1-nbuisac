int aaaa;
bool esDeTraspas;
Console.WriteLine("Entra un any -> ");
aaaa = Convert.ToInt32(Console.ReadLine());
// Aquests if els resoldrem altra vegada en una sola línia
if (aaaa % 4 == 0) {
    if (aaaa % 100 == 0) {
        if (aaaa % 400 == 0) {
            esDeTraspas = true;
        } else {
            esDeTraspas = false;
        }
    } else {
        esDeTraspas = true;
    }
} else {
    esDeTraspas = false;
}
// La següent línia equival als if de dalt
esDeTraspas = ((aaaa % 400 == 0) || (aaaa % 4 == 0 && aaaa % 100 != 0));

if (esDeTraspas) {
    Console.WriteLine("SI és de traspàs");
} else {
    Console.WriteLine("NO és de traspàs");
}
