// Lista 4 - Exercici 3
char resposta;

Console.Write("Vols continuar (s/n)? ");
resposta = Console.ReadKey(true).KeyChar;
while (resposta != 's' && resposta != 'S' &&
       resposta != 'n' && resposta != 'N')
{
    resposta = Console.ReadKey(true).KeyChar;

}
Console.WriteLine(resposta);
