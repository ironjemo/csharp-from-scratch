namespace HelloWorld
{//Creacion de clase
    class Program
    {

        static void Main()
        {//metodo statico se puede acceder sin nesecidad de una instancia
            DateOnly dateConverted = new DateOnly();
            String nameInput;
            String birthdayInput;
            Console.WriteLine("Hola bienvenido al calculador de años");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte (nameImput)");
            Console.WriteLine($"Escribe tu fecha de nacimiento dd/mm/yy:");
             birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput,out dateConverted);
            if(isDateValid==false)   Console.WriteLine($"La fecha de nacimiento es invalida, usted nos envio este dato erroneo{birthdayInput}");
            var Person = new Person{
                Name=nameInput,
                Birthday=dateConverted,
                Age= DateTime.Now.Year-dateConverted.Year
            };
            Console.WriteLine($"Tu nombre: {Person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {Person.Birthday}");
            Console.WriteLine($"Tu edad es : {Person.Age} años!");
            Console.WriteLine();//se genera un tiempo activandolo por una tecla
        }

    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly Birthday { get; set; }
    }

}