
class Elephant
{
    public string name;
    public int dlugoscTromby;
    public int waga;
    public string pochodzenie;

    public void kimJestem()
    {
        Console.WriteLine("Mam na imię:" + " " + name + " " + "mam trombę o długości" 
            + " " + dlugoscTromby + "cm " + "oraz ważę:" + " " + waga);
    }
   static void Main(string[] args)
    {
        Elephant Lucek = new Elephant { name = "Lucek", waga = 50, dlugoscTromby = 19 };
        Elephant Laura = new Elephant { name = "Laura", waga = 40, dlugoscTromby = 20 };

        Console.WriteLine("Wcisnij '1' jeśli chcesz Lucka, wciśnij '2' jeśli chcesz Laure oraz '3' (przedstawienie)");
        while(true)
        {
            char wchodzaceDane = Console.ReadKey(true).KeyChar;
            Console.WriteLine("Wybrałeś:" + " " + wchodzaceDane);
            if (wchodzaceDane == '1')
            {
                Console.WriteLine("Wywołanie Lucek.kimJestem()");
                Lucek.kimJestem();
            }
            else if (wchodzaceDane == '2')
            {
                Console.WriteLine("Wywołanie Laura.kimJestem()");
                Laura.kimJestem();
            }
            else if (wchodzaceDane == '3')
            {
                Elephant wielkoscStopy;
                wielkoscStopy = Lucek;
                Lucek = Laura;
                Laura = wielkoscStopy;
                Console.WriteLine("Referencje zostały przedstawione");
            }
            else if (wchodzaceDane == '4')
            {
                Lucek = Laura;
                Lucek.dlugoscTromby = 1234; // po wcisnięciu 4(klawisza) a potem 1(klawisza) zamiast Lucka będzie Laura
                Lucek.kimJestem();
            }
            else
            {
                return;
            }
            
            
        }

    }

}
