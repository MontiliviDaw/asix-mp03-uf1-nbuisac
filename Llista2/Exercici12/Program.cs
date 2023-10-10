// 12. L’alçada dels avions es mesuren en peus.
// 1 peu són 12 polzades. 1 polzada 2,54 cm.
// Fes el programa que passi de peus a metres.
int metres, peus;
Console.Write("Entra l'alçada en peus -> ");
peus = Convert.ToInt32(Console.ReadLine());
metres = (int)(peus * 12 * 2.54 / 100);
Console.WriteLine($"{peus} peus son {metres} metres");
