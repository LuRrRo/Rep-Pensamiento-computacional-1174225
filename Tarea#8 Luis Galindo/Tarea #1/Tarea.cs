
Console.WriteLine("Bienvenido \nIngrese su nombre completo por favor:");
string nombre = Console.ReadLine();
Console.WriteLine("Ahora, ingresa su altura en metros por favor:");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ahora, ingresa su edad por favor:");
int edad = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ahora, ingresa la inicial de tu mascota por favor:");
char inicial = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Su nombre es " + nombre + "\nsu edad es " + edad + " años \nSu altura es de " + altura + " metros \nY la inicial de su mascota es "+ inicial);
