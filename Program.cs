// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

string numString; // establecemos como string porque c# recibe solo string, tendremos que hacer un parse despues
int invertido = 0, num;
bool control = false; // utilizamos una variable de tipo booleano para controlar que el parseo sea existoso y que el usuario no ingrese un numero NO valido

while (!control)
{
    Console.WriteLine("Ingrese un numero a invertir:");
    numString = Console.ReadLine();
    control = int.TryParse(numString, out num); //se parsea poniendo el tipo de valor que queremos obtener y dentro de parentesis los parametros de (la variable a parsear y la variable de salida ya parseado)

    if (!control)
    {
        Console.WriteLine("Ingreso un numero invalido");
    }
    else
    {
        if (num > 0)
        {
            while (num > 0)
            {
                invertido = (invertido * 10) + (num % 10); //el numero invertido cuyo valor inicial es 0 se multiplica por 10 para asi despues sumarle el ultimo digito el cual se obtiene por medio de el operador MOD en 10
                num = num / 10; // el numero A invertir se va reduciendo hasta llegar a un solo digito
            }
            Console.WriteLine("El numero invertido es: " + invertido);
        }else{
            Console.WriteLine("El numero es un negativo o menor a 0");
        }
    }
} */
/* EJERCICIO 02 Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
 */


int opcion, num1, num2, resultado;
double num3,resultDouble;
string OpcionNumStr;
bool controlGral = true, controlNum1 = true, controlNum2 = true;


do
{
    Console.WriteLine(" 1-Sumar\n 2-Restar\n 3-Multiplicar\n 4-Dividir\n 5-Maximo\n 6-Minimo\n 7-Raiz cuadrada\n 8-Seno\n 9-Coseno\n 10-Parte entera de float\n 11-Valor absoluto\n 12-Cuadrado\n 13-Salir");
    OpcionNumStr = Console.ReadLine();
    controlGral = int.TryParse(OpcionNumStr, out opcion);
    if (!controlGral || (opcion < 0 || opcion > 13))
    {
        Console.WriteLine("Ingrese una opcion valida");
    }
    else if (opcion >=1 && opcion <= 6)
    {
        Console.WriteLine("Ingrese el primer numero");
        OpcionNumStr = Console.ReadLine();
        controlNum1 = int.TryParse(OpcionNumStr, out num1);
        Console.WriteLine("Ingrese el segundo numero");
        OpcionNumStr = Console.ReadLine();
        controlNum2 = int.TryParse(OpcionNumStr, out num2);
        if (!(controlNum1 && controlNum2))
        {
            Console.WriteLine("Los numeros que ingreso no son validos");
        }
        else
        {
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es:" + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es:" + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es:" + resultado);
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado de la division es:" + resultado);
                    break;
                case 5:
                    resultado = Math.Max(num1,num2);
                    Console.WriteLine("El mayor numero es:" + resultado);
                    break;
                case 6:
                    resultado = Math.Min(num1,num2);
                    Console.WriteLine("El menor numero es:" + resultado);
                    break;
                default:
                    break;
            }
        }
    }else if(opcion != 13){
        Console.WriteLine("Ingrese el numero");
        OpcionNumStr = Console.ReadLine();
        controlNum1 = double.TryParse(OpcionNumStr, out num3);
        switch (opcion)
        {
            case 7:
            resultDouble = Math.Sqrt(num3);
            Console.WriteLine("El resultado de la raiz es:" + resultDouble);
            break;
            case 8:
            resultDouble = Math.Sin(num3);
            Console.WriteLine("El resultado de el seno del numero es:" + resultDouble);
            break;
            case 9:
            resultDouble = Math.Cos(num3);
            Console.WriteLine("El resultado de el coseno del numero es:" + resultDouble);
            break;
            case 10:
            resultado = (int)Math.Floor(num3);
            Console.WriteLine("La parte entera del numero es:" + resultado);
            break;
            case 11:
            resultDouble = Math.Abs(num3);
            Console.WriteLine("El valor absoluto del numero es:" + resultDouble);
            break;
            case 12:
            resultDouble = Math.Pow(num3,2);
            Console.WriteLine("El cuadrado del numero es:" + resultDouble);
            break;
            default:
            break;
        }
    }
} while (opcion != 13);