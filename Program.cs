using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Lektion_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFerry færge = new CarFerry("M/F Fenja", 5000, 15000);

            Vehicle Bil1 = new Vehicle("ZZ27472", 2300);
            Vehicle Bil2 = new Vehicle("CT27291", 1700);
            Vehicle Bil3 = new Vehicle("DV345662", 2500);
            Vehicle Bil4 = new Vehicle("av442123", 5300);

            færge.addVehicle(Bil1);
            færge.addVehicle(Bil2);
            færge.addVehicle(Bil3);


            Console.WriteLine(færge.GetName() + " som vejer " + færge.GetWeight() + "kg");
            Console.WriteLine("har en maks kapacitet på " + færge.GetMaxWeight() + "kg");
            Console.WriteLine("sejler fra Esbjerg til Fanø med billerne");
            Console.WriteLine(Bil1.ToString());
            Console.WriteLine(Bil2.ToString());
            Console.WriteLine(Bil3.ToString());


            Console.WriteLine("samlet har billerne og færgen en vægt på " + færge.GetTotalWeight());

            if (færge.IsOverWeight())
            {
                Console.WriteLine(færge.GetName() + " er overbelastet!");
            }
            else
            {
                Console.WriteLine(færge.GetName() + " er ikke overbelastet.");
            }

            Console.WriteLine();

            Console.WriteLine("Når de rammer fanø sætter " + færge.GetName() + " en bil af og samler en anden op");
            færge.RemoveVehicle(Bil2);
            færge.addVehicle(Bil4);

            Console.WriteLine(færge.GetName());
            Console.WriteLine("maks kapacitet på " + færge.GetMaxWeight() + "kg");
            Console.WriteLine("sejler tilbage til Esbjerg fra Fanø med billerne");
            Console.WriteLine(Bil1.ToString());
            Console.WriteLine(Bil3.ToString());
            Console.WriteLine(Bil4.ToString());
            Console.WriteLine("samlet har billerne og færgen en vægt på " + færge.GetTotalWeight());

            if (færge.IsOverWeight())
            {
                Console.WriteLine(færge.GetName() + " er overbelastet!");
            }
            else
            {
                Console.WriteLine(færge.GetName() + " er ikke overbelastet.");
            }
        }
    }
}
