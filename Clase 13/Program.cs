/*using System.Diagnostics;

double CaF(double tempCelcius)
{
    double convFarenheit = (tempCelcius * 1.8)+32;
    return convFarenheit;
}
double FaC(double tempFarenheit)
{
    double convCelcius = (tempFarenheit - 32)*0.5555555556;
    return convCelcius;
}
void info()
{
    Console.WriteLine("Informacion del programador \n Nombre: Luis Rodrigo Galindo Giron \n Edad: 18 años \nLugar de residencia: Guatemala");
}
int temperatura;
Console.WriteLine("Bienvenido, seleccione una opción colocando el número de la opción \n1. Convertir de Celcius a Farenheit \n2. Convertir de Farenheit a celcius \n3. Info del programador \n4. Salir ");
int opcion = Convert.ToInt16(Console.ReadLine());
switch(opcion)
{
    case 1:
    Console.WriteLine("Ingrese su temeperatura en grados Celcius");
    temperatura = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine($"Su temperatura en grados Farenheit es de {CaF(temperatura)} grados");
    break;
    case 2:
    Console.WriteLine("Ingrese su temeperatura en grados Farenheit");
    temperatura = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine($"Su temperatura en grados Celcius es de {FaC(temperatura)} grados");
    break;
    case 3:
    info();
    break;
    default:
    Console.WriteLine("Gracias por usar el programa");
    break;
}*/

using System.Runtime.InteropServices.ObjectiveC;

string var = "hola";
if (var.Contains("o")==true)
{
    Console.WriteLine("jajajajja");
}
else
{
    Console.WriteLine(";alksdhf;lashd");
}