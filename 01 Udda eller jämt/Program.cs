/*
 *  1. Skriv ett uttryck som kollar om ett tal är udda eller jämnt.
 */

Console.Write("Ange ett tal: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Talet {0} är 1", number, number % 2 == 0 ? "jämt" : "udda");
 
