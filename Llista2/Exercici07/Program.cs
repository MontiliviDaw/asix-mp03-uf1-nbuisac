// Fer un programa que passi de pessetes a euros ( 1€ = 166’386 ptes)
const double CANVI = 166.386;
int pessetes;
double euros;
Console.Write("Entra el valor en pessetes -> ");
pessetes = Convert.ToInt32(Console.ReadLine());
euros = Math.Round(pessetes / CANVI, 2);
Console.WriteLine($"{pessetes} pessetes son {euros} euros");