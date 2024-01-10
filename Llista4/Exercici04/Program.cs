// Lista 4 - Exercici 4
char resposta;

Console.Write("Vols continuar (S/N)? ");
do
{
    resposta = Console.ReadKey(true).KeyChar;

} while (resposta != 's' && resposta != 'S' &&
         resposta != 'n' && resposta != 'N');
Console.WriteLine(resposta);
