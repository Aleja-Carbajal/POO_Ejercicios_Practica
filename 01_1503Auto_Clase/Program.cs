using System;

namespace _01_1503Auto_Clase
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Eficiencia = 20. Recorre 20 km por galon de gasolina y 0 = La gasolina actual
            var car01 = new Car(20,0); 

            car01.fuelLeft();//Checkeamos fuel
            car01.fillingFuel(10);//Refilamos
            car01.fuelLeft();//Checkeamos fuel again
            car01.advance(100);//Avanzamos 100 km
            car01.fuelLeft();//Chackeamos fuel again

        }
    }
}
