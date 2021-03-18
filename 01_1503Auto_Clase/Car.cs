using System;

namespace _01_1503Auto_Clase
{

    public class Car
    {
        //Atributos
        public double fuel;
        public double eficiency;

        //Constructores
        public Car(double pEficiency, double pFuel)
        {
            eficiency = pEficiency;
            fuel = pFuel;
        }

        //Métodos
        //Añade gasolina al tanque
        public void fillingFuel(double addFuel)
        {
            Console.WriteLine("Gasolina agregada!");
            fuel += addFuel;
            Console.WriteLine();
        }

        //Hace que el auto avance
        public void advance(double kilometers)
        {
            fuel -= (kilometers/eficiency);
            Console.WriteLine($"El auto a avanzado {kilometers} kilometros");
            Console.WriteLine();
        }

        //Devuelve la cantidad de gasolina que queda en el tanque
        public void fuelLeft()
        {
            Console.WriteLine($"Quedan {fuel} galones de gasolina en el auto.");
            Console.WriteLine();
        }
    }
}
