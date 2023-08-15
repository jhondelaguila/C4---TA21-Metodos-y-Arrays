using System;

namespace CalculadoraAreasYNumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Calcular área de una figura");
            Console.WriteLine("2. Generar números aleatorios");
            Console.WriteLine("3. Comprobar si un número es primo");
            Console.WriteLine("4. Calcular el factorial de un número");
            Console.WriteLine("5. Convertir decimal a binario");
            Console.WriteLine("6. Contar cifras de un número");
            Console.WriteLine("7. Convertir euros a otra moneda");
            Console.WriteLine("8. Crear array con valores de posición");
            Console.WriteLine("9. Crear array con números ingresados por usuario");
            Console.WriteLine("10. Hacer tabla de multiplicar");
            Console.WriteLine("11. Sumar elementos de un array");
            Console.WriteLine("12. Calcular media de elementos de un array");
            Console.WriteLine("13. Rellenar array con números aleatorios");
            Console.WriteLine("14. Verificar si un número existe en el array");
            Console.WriteLine("15. Invertir valores de un array");
            Console.WriteLine("16. Verificar si un array es capicúa");
            Console.WriteLine("17. Crear array con valores ingresados por usuario");
            Console.WriteLine("18. Crear array con números aleatorios y mostrar suma");
            Console.WriteLine("19. Crear array de números primos y encontrar el mayor");
            Console.WriteLine("20. Multiplicar arrays y mostrar contenido");
            Console.WriteLine("21. Filtrar números por dígito final");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularAreaFigura();
                    break;
                case 2:
                    GenerarNumerosAleatorios();           
                    break;
                case 3:
                    ComprobarNumeroPrimo();
                    break;
                case 4:
                    CalcularFactorial();
                    break;
                case 5:
                    ConvertirDecimalABinario();
                    break;
                case 6:
                    ContarCifras();
                    break;
                case 7:
                    ConvertirEurosAMoneda();
                    break;
                case 8:
                    CrearArrayPosiciones();
                    break;
                case 9:
                    CrearArrayNumerosUsuario();
                    break;
                case 10:
                    TablaMultiplicar();
                    break;
                case 11:
                    SumarElementosArray();
                    break;
                case 12:
                    CalcularMediaArray();
                    break;
                case 13:
                    RellenarArrayAleatorio();
                    break;
                case 14:
                    VerificarNumeroEnArray();
                    break;
                case 15:
                    InvertirValoresArray();
                    break;
                case 16:
                    VerificarArrayCapicua();
                    break;
                case 17:
                    CrearArrayIngresadosPorUsuario();
                    break;
                case 18:
                    CrearArrayAleatorioMostrarSuma();
                    break;
                case 19:
                    CrearArrayPrimosYEncontrarMayor();
                    break;
                case 20:
                    MultiplicarArraysYMostrarContenido();
                    break;
                case 21:
                    FiltrarNumerosPorDigitoFinal();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        
        }

        static void CalcularAreaFigura()
        {
            Console.WriteLine("Selecciona la figura:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Cuadrado");

            int opcionFigura = int.Parse(Console.ReadLine());

            switch (opcionFigura)
            {
                case 1:
                    Console.Write("Ingresa el radio del círculo: ");
                    double radioCirculo = double.Parse(Console.ReadLine());
                    double areaCirculo = CalcularAreaCirculo(radioCirculo);
                    Console.WriteLine($"El área del círculo es: {areaCirculo}");
                    break;
                case 2:
                    Console.Write("Ingresa la base del triángulo: ");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del triángulo: ");
                    double alturaTriangulo = double.Parse(Console.ReadLine());
                    double areaTriangulo = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
                    break;
                case 3:
                    Console.Write("Ingresa el lado del cuadrado: ");
                    double ladoCuadrado = double.Parse(Console.ReadLine());
                    double areaCuadrado = CalcularAreaCuadrado(ladoCuadrado);
                    Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
                    break;
                default:
                    Console.WriteLine("Figura no válida");
                    break;
            }
        }

        static double CalcularAreaCirculo(double radio)
        {
            const double PI = 3.14159;
            return Math.Pow(radio, 2) * PI;
        }

        static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        static double CalcularAreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        static void GenerarNumerosAleatorios()
        {
            Console.Write("Ingresa la cantidad de números aleatorios a generar: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el valor mínimo: ");
            int valorMinimo = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el valor máximo: ");
            int valorMaximo = int.Parse(Console.ReadLine());

            Random rand = new Random();
            Console.WriteLine("Números generados aleatoriamente:");

            for (int i = 0; i < cantidadNumeros; i++)
            {
                int numeroAleatorio = GenerarNumeroAleatorio(valorMinimo, valorMaximo, rand);
                Console.WriteLine(numeroAleatorio);
            }
        }

        private static int GenerarNumeroAleatorio(int min, int max, Random rand)
        {
            return rand.Next(min, max + 1);
        }

        static void ComprobarNumeroPrimo()
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            bool esPrimo = EsPrimo(numero);
            Console.WriteLine($"El número {numero} {(esPrimo ? "es" : "no es")} primo");
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        static void CalcularFactorial()
        {
            Console.Write("Ingresa un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());

            long factorial = CalcularFactorialNumero(numero);
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }

        static long CalcularFactorialNumero(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;

            long resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        static void ConvertirDecimalABinario()
        {
            Console.Write("Ingresa un número decimal: ");
            int numeroDecimal = int.Parse(Console.ReadLine());

            string numeroBinario = ConvertirDecimalABinario(numeroDecimal);
            Console.WriteLine($"El número binario es: {numeroBinario}");
        }

        static string ConvertirDecimalABinario(int numeroDecimal)
        {
            string binario = "";
            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % 2;
                binario = residuo + binario;
                numeroDecimal /= 2;
            }

            return binario;
        }

        static void ContarCifras()
        {
            int numero;

            do
            {
                Console.Write("Ingresa un número entero positivo: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero<0);

            int cifras = ContarCifrasNumero(numero);
            Console.WriteLine($"El número tiene {cifras} cifra{(cifras != 1 ? "s" : "")}");
        }

        static int ContarCifrasNumero(int numero)
        {
            if (numero == 0)
                return 1;

            int cifras = 0;
            while (numero > 0)
            {
                numero /= 10;
                cifras++;
            }

            return cifras;
        }

        static void ConvertirEurosAMoneda()
        {
            Console.Write("Ingresa la cantidad de euros: ");
            double euros = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la moneda a la que deseas convertir (libras/dólares/yenes): ");
            string moneda = Console.ReadLine();

            ConvertirDivisa(euros, moneda);
        }

        static void ConvertirDivisa(double euros, string moneda)
        {
            double conversion;
            switch (moneda)
            {
                case "libras":
                    conversion = euros * 0.86;
                    break;
                case "dólares":
                    conversion = euros * 1.28611;
                    break;
                case "yenes":
                    conversion = euros * 129.852;
                    break;
                default:
                    Console.WriteLine("Moneda no válida");
                    return;
            }

            Console.WriteLine($"La conversión de {euros} euros a {moneda} es: {conversion}");
        }

        static void CrearArrayPosiciones()
        {
            Console.Write("Ingresa la longitud del array: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] array = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("Contenido del array:");
            MostrarArray(array);
        }

        static void MostrarArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void CrearArrayNumerosUsuario()
        {
            Console.Write("Ingresa la longitud del array: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] array = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"Ingresa el número en la posición {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Contenido del array:");
            MostrarArray(array);
        }

        static void TablaMultiplicar()
        {
            Console.Write("Ingresa el número para la tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabla de multiplicar:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }

        static void SumarElementosArray()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingresa el valor en la posición {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int suma = SumarArray(array);
            Console.WriteLine($"La suma de los elementos del array es: {suma}");
        }

        static int SumarArray(int[] array)
        {
            int suma = 0;
            foreach (int num in array)
            {
                suma += num;
            }
            return suma;
        }

        static void CalcularMediaArray()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingresa el valor en la posición {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            double media = CalcularMedia(array);
            Console.WriteLine($"La media de los elementos del array es: {media}");
        }

        static double CalcularMedia(int[] array)
        {
            int suma = SumarArray(array);
            return (double)suma / array.Length;
        }

        static int[] RellenarArrayAleatorio()
        {
            Console.Write("Ingresa la longitud del array: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] array = new int[longitud];
            Random rand = new Random();

            for (int i = 0; i < longitud; i++)
            {
                array[i] = rand.Next(1, 11);
            }

            Console.WriteLine("Array rellenado con números aleatorios:");
            MostrarArray(array);
            return array;
        }

        static void VerificarNumeroEnArray()
        {
            int[] array = RellenarArrayAleatorio();

            Console.Write("Ingresa el número a verificar: ");
            int numero = int.Parse(Console.ReadLine());

            bool existe = VerificarExistenciaNumero(array, numero);
            Console.WriteLine($"El número {numero} {(existe ? "existe" : "no existe")} en el array.");
        }

        static bool VerificarExistenciaNumero(int[] array, int numero)
        {
            foreach (int num in array)
            {
                if (num == numero)
                    return true;
            }
            return false;
        }

        static void InvertirValoresArray()
        {
            Console.Write("Ingresa la longitud del array: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] arrayOriginal = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"Ingresa el valor en la posición {i}: ");
                arrayOriginal[i] = int.Parse(Console.ReadLine());
            }

            int[] arrayInvertido = InvertirArray(arrayOriginal);

            Console.WriteLine("Array original:");
            MostrarArray(arrayOriginal);

            Console.WriteLine("Array invertido:");
            MostrarArray(arrayInvertido);
        }

        static int[] InvertirArray(int[] array)
        {
            int[] arrayInvertido = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayInvertido[i] = array[array.Length - i - 1];
            }
            return arrayInvertido;
        }

        static void VerificarArrayCapicua()
        {
            Console.Write("Ingresa la longitud del array: ");
            int longitud = int.Parse(Console.ReadLine());

            int[] array = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"Ingresa el valor en la posición {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            bool esCapicua = VerificarCapicua(array);
            Console.WriteLine($"El array {(esCapicua ? "es" : "no es")} capicúa.");
        }

        static bool VerificarCapicua(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                    return false;
            }
            return true;
        }

        static void CrearArrayIngresadosPorUsuario()
        {
            int[] array = RellenarArray();

            MostrarArrayConIndices(array);
        }

        static void MostrarArrayConIndices(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Índice: {i}, Valor: {array[i]}");
            }
        }

        static int[] RellenarArray()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingresa el valor en la posición {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static void CrearArrayAleatorioMostrarSuma()
        {
            Console.Write("Ingresa el tamaño del array: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array = RellenarArrayAleatorio(tamaño, 0, 9);
            MostrarArrayConSuma(array);
        }

        static int[] RellenarArrayAleatorio(int tamaño, int min, int max)
        {
            int[] array = new int[tamaño];
            Random rand = new Random();

            for (int i = 0; i < tamaño; i++)
            {
                array[i] = GenerarNumeroAleatorio(min, max, rand);
            }

            return array;
        }

        static void MostrarArrayConSuma(int[] array)
        {
            Console.WriteLine("Contenido del array:");
            MostrarArray(array);

            int suma = SumarArray(array);
            Console.WriteLine($"La suma de los elementos del array es: {suma}");
        }

        static void CrearArrayPrimosYEncontrarMayor()
        {
            Console.Write("Ingresa el tamaño del array: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array = CrearArrayPrimos(tamaño);
            MostrarArray(array);

            int mayor = EncontrarMayor(array);
            Console.WriteLine($"El mayor número primo es: {mayor}");
        }

        static int[] CrearArrayPrimos(int tamaño)
        {
            int[] array = new int[tamaño];
            Random rand = new Random();

            for (int i = 0; i < tamaño; i++)
            {
                int numeroAleatorio;
                do
                {
                    numeroAleatorio = GenerarNumeroAleatorio(2, 100, rand);
                } while (!EsPrimo(numeroAleatorio));

                array[i] = numeroAleatorio;
            }

            return array;
        }

        static int EncontrarMayor(int[] array)
        {
            int mayor = int.MinValue;
            foreach (int num in array)
            {
                if (num > mayor)
                    mayor = num;
            }
            return mayor;
        }

        static void MultiplicarArraysYMostrarContenido()
        {
            Console.Write("Ingresa el tamaño de los arrays: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array1 = RellenarArrayAleatorio(tamaño, 1, 10);
            int[] array2 = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                array2[i] = array1[i];
            }

            int[] arrayResultado = MultiplicarArrays(array1, array2);

            Console.WriteLine("Contenido del primer array:");
            MostrarArray(array1);

            Console.WriteLine("Contenido del segundo array:");
            MostrarArray(array2);

            Console.WriteLine("Resultado de la multiplicación:");
            MostrarArray(arrayResultado);
        }

        static int[] MultiplicarArrays(int[] array1, int[] array2)
        {
            int[] arrayResultado = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                arrayResultado[i] = array1[i] * array2[i];
            }
            return arrayResultado;
        }

        static void FiltrarNumerosPorDigitoFinal()
        {
            Console.Write("Ingresa el tamaño del array: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array = RellenarArrayAleatorio(tamaño, 1, 300);

            Console.Write("Ingresa el dígito final a filtrar: ");
            int digito = int.Parse(Console.ReadLine());

            int[] arrayFiltrado = FiltrarPorDigitoFinal(array, digito);

            Console.WriteLine("Contenido del array original:");
            MostrarArray(array);

            Console.WriteLine($"Números que terminan en {digito}:");
            MostrarArray(arrayFiltrado);
        }

        static int[] FiltrarPorDigitoFinal(int[] array, int digito)
        {
            int contador = 0;
            foreach (int num in array)
            {
                if (num % 10 == digito)
                    contador++;
            }

            int[] arrayFiltrado = new int[contador];
            int index = 0;

            foreach (int num in array)
            {
                if (num % 10 == digito)
                {
                    arrayFiltrado[index] = num;
                    index++;
                }
            }

            return arrayFiltrado;
        }
    }
}
