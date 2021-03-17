//Clase que se crea aparte

using System;

namespace _02_1503Cocina_Clase
{
    public class Kitchen
    {
        //Atributos 
        
        private int kitchenBurners;
        private string color;
        private string brand;
        private string fuel;
        private bool oven;

        //Constructores:
        public Kitchen(int pBurn, string pCol, string pBrand, string pFuel, bool pOven)
        {
            kitchenBurners = pBurn;
            color = pCol;
            brand = pBrand;
            fuel = pFuel;
            oven = pOven;
        }

        //Métodos
        public void turnOn()
        {
            Console.WriteLine("Encendiendo...");
        }

        public void turnOff()
        {
            Console.WriteLine("Apagando...");
        }

        public void beak()
        {
            if (oven)
                Console.WriteLine("Horneando...");
            else
                Console.WriteLine("Error...");
        }

        public string info()
        {
            string info = "Marca: " + brand + "\nColor: " + color;
            return info;
        }

    }
}
