// Fer un programa que passi d’euros a pessetes ( 1€ = 166’386 ptes)
const double CANVI = 166.386; 
int pessetes;
double euros;
Console.Write("Entra el valor en euros -> ");
euros = Convert.ToDouble(Console.ReadLine());
pessetes = (int) Math.Round(euros * CANVI, 0);
Console.WriteLine($"{euros} euros son {pessetes} pessetes.");