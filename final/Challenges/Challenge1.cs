using System;

namespace itm.csharp.basic
{
    /* Solicita al usuario un número y eleva este número al cuadrado solo si es positivo */

    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine($"Resultado: {num * num}");
            else if (num < 0)
                Console.WriteLine("Resultado: Número negativo.");
            else
                Console.WriteLine("Resultado: 0");
        }
    }


    /* Solicita al usuario dos números. Si el primero es mayor, devuelve su doble, de lo contrario, devuelve el triple del segundo. */

    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"Resultado: {num1 * 2}");
            else
                Console.WriteLine($"Resultado: {num2 * 3}");
        }
    }

    /* Pide al usuario un número.Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado. */

    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine($"Resultado: {Math.Sqrt(num)}");
            else
                Console.WriteLine($"Resultado: {num * num}");
        }
    }

    /* Pide al usuario el radio de un círculo y calcula su perímetro. */

    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());

            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"Resultado: {perimetro:F2}");
        }
    }

    /* Solicita al usuario un número entre 1 y 7 y muestra el día de la 
      semana correspondiente, pero solo considerando los días laborables. */

    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 5)
            {
                string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                Console.WriteLine($"Resultado: {dias[num - 1]}");
            }
            else
            {
                Console.WriteLine("Número fuera del rango laboral.");
            }
        }
    }

    /* Solicita al usuario su salario anual y, si este excede los 12000, 
       muestra el impuesto a pagar que es el 15% del excedente. */

    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario anual:");
            double salario = double.Parse(Console.ReadLine());

            if (salario > 12000)
            {
                double impuesto = (salario - 12000) * 0.15;
                Console.WriteLine($"Resultado: {impuesto}");
            }
            else
            {
                Console.WriteLine("No debe impuestos.");
            }
        }
    }

    /* Solicita dos números y muestra el residuo de la división 
      del primero entre el segundo. */

    public class Challenge7
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int residuo = num1 % num2;
            Console.WriteLine($"Resultado: {residuo}");
        }
    }

    /* Calcula y muestra la suma de los números pares entre 1 y 50. */

    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;

            for (int i = 2; i <= 50; i += 2)
            {
                suma += i;
            }

            Console.WriteLine($"Resultado: {suma}");
        }
    }


    //solicita al usuario que ingrese dos fracciones en formato "a/b" y "c/d", calcula la diferencia entre ellas 
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese la primera fracción (a/b):");
            string[] fraction1 = Console.ReadLine().Split('/');
            Console.WriteLine("Ingrese la segunda fracción (c/d):");
            string[] fraction2 = Console.ReadLine().Split('/');

            int num1 = int.Parse(fraction1[0]);
            int den1 = int.Parse(fraction1[1]);
            int num2 = int.Parse(fraction2[0]);
            int den2 = int.Parse(fraction2[1]);

            // Calculando la diferencia de fracciones: (a/b) - (c/d) = (a*d - c*b) / (b*d)
            int numDiff = num1 * den2 - num2 * den1;
            int denDiff = den1 * den2;

            // Simplificación de fracción
            int gcd = GCD(Math.Abs(numDiff), denDiff);
            numDiff /= gcd;
            denDiff /= gcd;

            // Mostrar el resultado
            if (numDiff == 0)
                Console.WriteLine("Resultado: 0");
            else
                Console.WriteLine($"Resultado: {numDiff}/{denDiff}");
        }

        // Método para calcular el Máximo Común Divisor (MCD)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                Console.WriteLine($"La longitud de la palabra es: {palabra.Length}");
            }
            else
            {
                Console.WriteLine("No ingresó ninguna palabra.");
            }
        }
    }
    // Se pide al usuario que escriba cuatro numeros y calcule el promedio
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto número:");
            double num4 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
        }
    }

    //Pide al usuario cinco números y muestra el más pequeño. 
    public class Challenge12
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto número:");
            double num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el quinto número:");
            double num5 = double.Parse(Console.ReadLine());

            double menor = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));

            Console.WriteLine($"El número más pequeño es: {menor}");
        }
    }

    // Pide una palabra al usuario y devuelve el número de vocales. 	

    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine().ToLower(); // Convertimos la palabra a minúsculas

            int contadorVocales = 0;
            foreach (char letra in palabra)
            {
                if ("aeiou".Contains(letra)) // Verificamos si la letra es una vocal
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine($"El número de vocales en la palabra es: {contadorVocales}");
        }
    }

    //Muestra el factorial de un numero
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un número negativo.");
            }
            else
            {
                long factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
        }
    }
    //: Pide un número al usuario y verifica si está en el rango de 10 a 20, ambos incluidos.
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Está en el rango.");
            }
            else
            {
                Console.WriteLine("Fuera del rango.");
            }
        }
    }
}
