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
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\tTrabajo Practico 5\n");
                Console.WriteLine("--------------------------------------------------------------------------");

                Console.WriteLine("Ingrese una opcion:\n Ejercicio 1 = 1 | Ejercicio 2 = 2 | Ejercicio 3 = 3 | Ejercicio 4 = 4 | Salir = 0");
                valor = Console.ReadLine();
                valor = control(valor);
                if(valor != " ")
                {
                    opcion = Convert.ToInt32(valor);
                }
                else
                {
                    opcion = -1;
                }
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
                            Console.Clear();
                            eleccionEjercicio3();
                            Console.Clear();
                            break;
                            case 4:
                            ejercicio4();
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
            Console.WriteLine("\t\t\tSelecciono la opcion Ejercicio 1");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");

            string valor;
            double num1 = 0;
            Console.WriteLine("Ingrese el numero a invertir");
            valor = Console.ReadLine();
            valor = controlNum(valor);
            if (valor!= " ")
            {
                num1 = Convert.ToDouble(valor);
            }

            if (num1 > 0)
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
            double numero1 = 0, numero2 = 0, resultado = 0;
            char resp;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\tSelecciono la opcion Ejercicio 2");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese la opcion que desea calcular: 1 = Sumar. 2 = Restar. 3 = Multiplicar. 4 = Dividir. 0 = Regresar al menu anterior ");
            valor = Console.ReadLine();
            valor = control(valor);
            if (valor != " ")
            {
                opcion = Convert.ToInt32(valor);
            }
            else
            {
                opcion = -1;
            }
            while (opcion != 0)
            {

                if (opcion > 0 && opcion < 5)
                {
                    Console.WriteLine("Eligio la opcion: " + opcion);
                    Console.WriteLine("Ingrese 2 numeros para calcular la operacion elegida ");
                    Console.WriteLine("Primer numero: " + (valor1 = Console.ReadLine()));
                    valor1 = controlNum(valor1);
                    if (valor1 != " ")
                    {
                        numero1 = Convert.ToInt32(valor1);
                    }
                    Console.WriteLine("Segundo numero: " + (valor2 = Console.ReadLine()));
                    valor2 = controlNum(valor2);
                    if (valor2 != " ")
                    {
                        numero2 = Convert.ToInt32(valor2);
                    }
                    Console.WriteLine("\n");

                    if (valor1 != " " && valor2 != " ")
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
                    Console.WriteLine("Ingrese la opcion que desea calcular: 1 = Sumar. 2 = Restar. 3 = Multiplicar. 4 = Dividir. 0 = Regresar al menu anterior");
                    valor = Console.ReadLine();
                    valor = control(valor);
                    if (valor != " ")
                    {
                        opcion = Convert.ToInt32(valor);
                    }
                    else
                    {
                        opcion = -1;
                    }
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
            Console.WriteLine("\t\t\tSelecciono la opcion Ejercicio 3. Apartado 1");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");

            string valor;
            double num = 0;

            Console.WriteLine("Ingrese el numero para calcular\nSe calculara de este: a) Valor absoluto. b) Potencia cuadrada. c) Raiz cuadrada. d) Seno. e) Coseno. f) Numero sin parte decimal");

            valor = Console.ReadLine();
            valor = controlNum(valor);
            if (valor != " ")
            {
                num = Convert.ToInt32(valor);
            }
            if (valor != " ")
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
            Console.WriteLine("\t\t\tSelecciono la opcion Ejercicio 3. Apartado 2");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");

            string valor1,valor2;
            double num1 =0 ,num2 = 0 ,max,min;

            Console.WriteLine("Ingrese dos numero para calcular su maximo y su minimo");
            Console.WriteLine("Primer numero: " + (valor1 = Console.ReadLine()));
            valor1 = controlNum(valor1);
            if (valor1 != " ")
            {
                num1 = Convert.ToInt32(valor1);
            }
            Console.WriteLine("Segundo numero: " + (valor2 = Console.ReadLine()));
            valor2 = controlNum(valor2);
            if (valor2 != " ")
            {
                num2 = Convert.ToInt32(valor2);
            }

            if (valor1 != " " && valor2 != " ")
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
            while(cond == 0 && (i<valor1.Length) || valor.Length == 0)
            {
                if (valor.Length != 0)
                {
                    if (Char.IsDigit(valores[i]) == false)
                    {
                        valor = " ";
                        cond = 1;
                    }
                }
                else
                {
                    valor = " ";
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
            while (cond == 0 && (i < valor.Length) || valor.Length == 0)
            {
                if(valor.Length != 0)
                {
                    if (Char.IsDigit(valores[i]) == false)
                    {
                        valor = " ";
                        cond = 1;
                    }
                }
                else
                {
                    valor = " ";
                    cond = 1;
                }
                i++;
            }
            return valor;
        }
        public static void eleccionEjercicio3()
        {
            int opcion;
            string valor;
            Console.WriteLine("Seleccione apartado del ejercicio 3 :\n Apartado 1 = 1 | Apartado 2 = 2\n");
            valor = Console.ReadLine();
            valor = control(valor);
            if (valor != " ")
            {
                opcion = Convert.ToInt32(valor);
            }
            else
            {
                opcion = -1;
            }
            if (opcion == 1)
            {
                ejercicio3();
            }
            else
            {
                ejercicio3_2();
            }
        }
        public static void ejercicio4()
        {
            string cadena, cadena2, palabra;
            char letra;
            int i = 0;

            Console.WriteLine("Ingrese una cadena de texto");
            cadena = Console.ReadLine();
            Console.WriteLine("\nIngrese una letra para buscar en la cadena");
            letra = Convert.ToChar(Console.Read());
            Console.ReadLine();
            if(cadena.Contains(letra))
            {
                Console.WriteLine("La letra " + letra + " si se encuentra en la cadena");
            }
            else
            {
                Console.WriteLine("La letra " + letra + " no se encuentra en la cadena");
            }

            Console.WriteLine("La longitud de la cadena es: " + cadena.Length);

            Console.WriteLine("Ingrese una segunda cadena de texto");
            cadena2 = Console.ReadLine();
            Console.WriteLine("Las cadenas 1 y 2 concatenadas son: " + String.Concat(cadena, cadena2));
            Console.WriteLine("\n");
           /* Console.WriteLine("Ingrese una palabra para extraer de la cadena 1: " + cadena);
            palabra = Console.ReadLine();
            string[] arreCadena = cadena.Split(' ');
            char[] arrePalabra = palabra.ToCharArray();
            int x1 = 0;
            int x2 = (palabra.Length)-1;
            cadena2 = cadena.Substring(x1, x2);
            Console.WriteLine(cadena2);
            foreach( string p1 in arreCadena)
            {
                int x = p1.IndexOf(arrePalabra[0]);
                Console.WriteLine("   {0}", p1.Substring(x + 2));
            }*/

            //falta terminar 

            Console.ReadKey();
        }
    }
}
