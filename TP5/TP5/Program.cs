using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            int opcion;
            do
            {
                Console.WriteLine("Ingrese una opcion:\n Invertir numero = 1 | Calculadora = 2 | Calculadora 2.0 = 3 | Calculadora 2.1 = 4 | Salir = 0");
                num = Console.ReadLine();
                opcion = Convert.ToInt32(num);
                if (opcion > 0 && opcion < 5)
                {
                    switch (opcion)
                    {
                            case 1:
                            ejercicio1();
                            Console.Clear();
                            break;
                            case 2: 
                            ejercicio2();
                            Console.Clear();
                            break;
                            case 3:
                            ejercicio3();
                            Console.Clear();
                            break;
                            case 4:
                            break;
                            default:
                            break;

                    }
                }
                else if(opcion != 0)
                {
                    Console.WriteLine("Opcion Incorrecta");
                }


            } while (opcion != 0);
        }
        public static void ejercicio1()
        {

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\tSelecciono la opcion Invertir");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");

            string valor;
            int num1;
            Console.WriteLine("Ingrese el numero a invertir");
            valor = Console.ReadLine();
            num1 = Convert.ToInt32(valor);
            if(num1 > 0)
            {
                char[] numero = Convert.ToString(num1).ToCharArray();
                Array.Reverse(numero);
                num1 = Convert.ToInt32(String.Concat(numero));
                Console.WriteLine("El numero invertido es: " + num1);

            }
            else
            {
                Console.WriteLine("El numero es menor que 0, no sera invertido");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        public static void ejercicio2()
        {
            float opcion, numero1, numero2, resultado = 0;
            char resp;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\tSelecciono la opcion Calculadora");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese la opcion que desea calcular: Sumar Restar Multiplicar Dividir ");
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion != 0)
            {

                if (opcion > 0 && opcion < 5)
                {
                    Console.WriteLine("Eligio la opcion: " + opcion);
                    Console.WriteLine("Ingrese 2 numeros para calcular la operacion elegida ");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            resultado = numero1 + numero2;
                            Console.WriteLine("El resultado de la suma es: " + Convert.ToInt32(resultado));
                            break;
                        case 2:
                            resultado = numero1- numero2;
                            Console.WriteLine("El resultado de la resta es: " + Convert.ToInt32(resultado));
                            break;
                        case 3:
                            resultado = numero1 * numero2;
                            Console.WriteLine("El resultado de la multiplicacion es: " + Convert.ToInt32(resultado));
                            break;
                        case 4:
                            resultado = numero1 / numero2;
                            Console.WriteLine("El resultado de la division es: " + resultado);
                            break;
                        default:
                            break;

                    }
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opcion Incorrecta");
                }
                Console.WriteLine("Desea realizar otro calculo? S/N");
                resp = Convert.ToChar(Console.Read());
                Console.ReadLine();
                resp = Char.ToUpper(resp);
                if(resp == 'S')
                {
                    Console.WriteLine("Ingrese la opcion que desea calcular: Sumar Restar Multiplicar Dividir ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    opcion = 0;
                }


            }
        }
        public static void ejercicio3()
        {

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\tSelecciono la opcion Calculadora 2.0");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");

            string valor;
            double num;

            Console.WriteLine("Ingrese el numero para calcular\nSe calculara de este: a) Valor absoluto. b) Potencia cuadrada. c) Raiz cuadrada. d) Seno. e) Coseno. f) Numero sin parte decimal");

            valor = Console.ReadLine();
            valor = String.Join(",",valor.Split("."));
            num = Convert.ToDouble(valor);
            Console.WriteLine("El valor absoluto de " + num + " es igual a: " + Math.Abs(num));
            Console.WriteLine("La potencia cuadrada de " + num + " es igual a: " + Math.Pow(num, 2));
            Console.WriteLine("La raiz cuadrada de " + num + " es igual a: " + Math.Sqrt(num));
            Console.WriteLine("El seno de "+ num +" es igual a: " + Math.Sin(num));
            Console.WriteLine("El coseno de " + num + " es igual a: " + Math.Cos(num));
            Console.WriteLine("El numero " + num + " sin parte decimal es igual a: " + Math.Truncate(num));
            Console.WriteLine("\n");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
    }
}
