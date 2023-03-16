using System;
using System.Collections.Generic;

class Ovi
{

    public enum Oventila { Auki, Kiinni, Lukossa }

    static void Main()
    {
        string Ovi;

        Oventila tila = Oventila.Lukossa;
        while (true)
        {
            Ovi = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Mitä ovelle tehdään = {0}", Ovi);
            Console.WriteLine(" ");

            if (tila == Oventila.Lukossa)
            {
                if (Ovi == "Avaa-lukko")
                {
                    Console.WriteLine("Lukko ovi on lukitsematta");
                    tila = Oventila.Kiinni;

                }
            }

            if (tila == Oventila.Kiinni)
            {


                if (Ovi == "Avaa")
                {
                    Console.WriteLine("Ovi on avattu");
                    tila = Oventila.Auki;

                }
            }

            if (tila == Oventila.Auki)
            {
                if (Ovi == "Sulje")
                {
                    Console.WriteLine("Ovi on suljettu");
                    tila = Oventila.Kiinni;

                }
            }

            if (tila == Oventila.Kiinni)
            {
                if (Ovi == "Lukitse")
                {
                    Console.WriteLine("Ovi on lukittu");
                    tila = Oventila.Lukossa;

                }
            }




        }


    }
}