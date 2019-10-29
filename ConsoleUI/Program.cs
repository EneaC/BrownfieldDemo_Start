using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, ttl;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine());
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time:");
            //bool cont = bool.Parse(Console.ReadLine());   original
            //creamos un string para la lectura de la linea y si el usuario escribes yes cont sera true. Por defecto la iniciamos en false.
            bool cont = false;//= bool.Parse(Console.ReadLine());
            string texto = Console.ReadLine();
            if (texto == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            // mientras cont sea true
            while (cont == true)
            //do
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time:");
                //cont = bool.Parse(Console.ReadLine());
                // tambien lo cambiamos dentro del bucle podriamos crear un metodo para verificar si es verdadero o falso
                texto = Console.ReadLine();
                if (texto == "yes")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }

            }
           
            //while (cont == true); 
            // este while sobra. Tanto si añadimos como si no tenemos que calcular la factura.
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                //if (ents[i].WorkDone.Contains("Acme"))
                // comprobamos si la empresa es ACME. Cambiamos el nombre a UPERCASE
                if (ents[i].WorkDone.Contains("ACME"))
                {
                    ttl += i;
                }
            }
            Console.WriteLine("Simulating Sending email to ACME"); //Acme
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC"))
                {
                    ttl += i;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
                //falta esta linea para saber lo que ganamos por nuestro tiempo
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            else
            {
                //falta esta linea para saber lo que ganamos por las horas
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
            
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
