int any;
int d1, d2, d3, d4;
Console.Write("Entra un any -> ");
any = Convert.ToInt32(Console.ReadLine());

d4 = any % 10;
any = any / 10;
d3 = any % 10;

any = any / 10;
d2 = any % 10;
any = any / 10;
d1 = any % 10;
any = any / 10;

Console.WriteLine($"L'any dígit a dígit {d1} {d2} {d3} {d4}");