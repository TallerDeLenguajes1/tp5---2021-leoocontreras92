using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int opcion;
            do
            {
                Console.WriteLine("Ingrese una opcion:\n Invertir numero = 1 | Calculadora = 2 | Calculadora 2.0 = 3 | Calculadora 2.1 = 4 | Salir = 0");
                valor = Console.ReadLine();
                valor = control(valor);
                opcion = Convert.ToInt32(valor);
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
                            ejercicio3_2();
                            Console.Clear();
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
            double num1;
            Console.WriteLine("Ingrese el numero a invertir");
            valor = Console.ReadLine();
            valor = controlNum(valor);
            num1 = Convert.ToDouble(valor);

            if(num1 > 0)
            {
                char[] numero = Convert.ToString(num1).ToCharArray();
                Array.Reverse(numero);
                num1 = Convert.ToDouble(String.Concat(numero));
                Console.WriteLine("El numero invertido es: " + num1);

            }
            else
            {
                Console.WriteLine("El numero es menor que 0 o no es un numero, no sera invertido");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        public static void ejercicio2()
        {
            string valor, valor1, valor2;
            int opcion;
            double numero1, numero2, resultado = 0;
            char resp;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\tSelecciono la opcion Calculadora");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese la opcion que desea calcular: 1 = Sumar. 2 = Restar. 3 = Multiplicar. 4 = Dividir ");
            valor = Console.ReadLine();
            valor = control(valor);
            opcion = Convert.ToInt32(valor);
            while (opcion != 0)
            {

                if (opcion > 0 && opcion < 5)
                {
                    Console.WriteLine("Eligio la opcion: " + opcion);
                    Console.WriteLine("Ingrese 2 numeros para calcular la operacion elegida ");
                    Console.WriteLine("Primer numero: " + (valor1 = Console.ReadLine()));
                    valor1 = controlNum(valor1);
                    numero1 = Convert.ToDouble(valor1);
                    Console.WriteLine("Segundo numero: " + (valor2 = Console.ReadLine()));
                    valor2 = controlNum(valor2);
                    numero2 = Convert.ToDouble(valor2);
                    Console.WriteLine("\n");

                    if (valor1 != "0" && valor2 != "0")
                    {
                        switch (opcion)
                        {
                            case 1:
                                resultado = numero1 + numero2;
                                Console.WriteLine("El resultado de la suma es: " + resultado);
                                break;
                            case 2:
                                resultado = numero1 - numero2;
                                Console.WriteLine("El resultado de la resta es: " + resultado);
                                break;
                            case 3:
                                resultado = numero1 * numero2;
                                Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                                break;
                            case 4:
                                resultado = numero1 / numero2;
                                Console.WriteLine("El resultado de la division es: " + resultado);
                                break;
                            default:
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingreso Valores incorrectos");
                    }
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opcion Incorrecta");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Desea realizar otro calculo? S/N");
                resp = Convert.ToChar(Console.Read());
                Console.ReadLine();
                Console.WriteLine("\n");
                resp = Char.ToUpper(resp);
                if(resp == 'S')
                {
                    Console.WriteLine("Ingrese la opcion que desea calcular: 1 = Sumar. 2 = Restar. 3 = Multiplicar. 4 = Dividir ");
                    valor = Console.ReadLine();
                    valor = control(valor);
                    opcion = Convert.ToInt32(valor);
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
            valor = controlNum(valor);
            num = Convert.ToDouble(valor);
            if (valor != "0")
            {
                Console.WriteLine("El valor absoluto de " + num + " es igual a: " + Math.Abs(num));
                Console.WriteLine("La potencia cuadrada de " + num + " es igual a: " + Math.Pow(num, 2));
                Console.WriteLine("La raiz cuadrada de " + num + " es igual a: " + Math.Sqrt(num));
                Console.WriteLine("El seno de " + num + " es igual a: " + Math.Sin(num));
                Console.WriteLine("El coseno de " + num + " es igual a: " + Math.Cos(num));
                Console.WriteLine("El numero " + num + " sin parte decimal es igual a: " + Math.Truncate(num));
            }
            else
            {
                Console.WriteLine("Ingreso un valor incorrecto");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
        public static void ejercicio3_2()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\tSelecciono la opcion Calcular maximo y minimo");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");

            string valor1,valor2;
            double num1,num2,max,min;

            Console.WriteLine("Ingrese dos numero para calcular su maximo y su minimo");
            Console.WriteLine("Primer numero: " + (valor1 = Console.ReadLine()));
            valor1 = controlNum(valor1);
            num1 = Convert.ToDouble(valor1);
            Console.WriteLine("Segundo numero: " + (valor2 = Console.ReadLine()));
            valor2 = controlNum(valor2);
            num2 = Convert.ToDouble(valor2);

            if(valor1 != "0" && valor2 != "0")
            {
                max = Math.Max(num1, num2);
                min = Math.Min(num1, num2);
                Console.WriteLine("\n");
                Console.WriteLine("El maximo entre los numeros ingresados es: " + max);
                Console.WriteLine("El minimo entre los numeros ingresados es: " + min);
            }
            else
            {
                Console.WriteLine("Ingreso valores incorrectos");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        public static string controlNum(string valor)
        {


            int cond = 0, i = 0;
            string valor1;

            valor = String.Join(",", valor.Split("."));
            valor1 = String.Join(String.Empty, valor.Split(',','.'));
            char[] valores = valor1.ToCharArray();
            while(cond == 0 && (i<valor1.Length))
            {
                if (Char.IsDigit(valores[i])==false)
                {
                    valor = "0";
                    cond = 1;
                }
                i++;
            }
            return valor;
        }
        public static string control(string valor)
        {


            int cond = 0, i = 0;

            char[] valores = valor.ToCharArray();
            while (cond == 0 && (i < valor.Length))
            {
                if (Char.IsDigit(valores[i]) == false)
                {
                    valor = "-1";
                    cond = 1;
                }
                i++;
            }
            return valor;
        }
    }

}
