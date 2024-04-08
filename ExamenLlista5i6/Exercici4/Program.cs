// 
string str1, str2;

Console.Write("Entra una frase -> ");
str1 = Console.ReadLine();
Console.Write("Entra una seqüència -> ");
str2 = Console.ReadLine();
if (str1.Contains(str2)) {
    int q, pos;
    q = 0;
    pos = str1.IndexOf(str2);
    while (pos >= 0) {
        q++;
        pos = str1.IndexOf(str2, pos+1);
    }
    Console.WriteLine($"{str2} apareix {q} vegades a {str1}");
} else {
    Console.WriteLine($"No apareix {str2} dins {str1}");
}