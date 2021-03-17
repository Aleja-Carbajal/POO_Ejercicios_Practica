/*¿Que caracterısticas definen a todas las cocinas? ¿Que acciones realizan
todas las cocinas? ¿Que atributos y metodos debe tener una clase Cocina?*/

//Clase: Cocina
//Objeto (instancias): cocina01, cocina02, etc.

using System;

namespace _02_1503Cocina_Clase
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Aquí instanciaremos nuestros objetos
            Kitchen kitchen01 = new Kitchen(6, "Negra", "Ford", "Gas", true);
            Console.WriteLine(kitchen01.info());
            kitchen01.turnOn();
            kitchen01.turnOff();
            kitchen01.beak();
            
        }
    }
}
