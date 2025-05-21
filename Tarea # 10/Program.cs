Console.WriteLine("Bienvendo! Por favor ingrese la hora del día en formato de 24 horas(solo coloque la hora):");
int horaDelDía = Convert.ToInt16(Console.ReadLine());
if (horaDelDía >= 0 && horaDelDía <= 11)
{ 
    Console.WriteLine("Buenos dias!");
}
else if (horaDelDía >= 12 && horaDelDía <= 18)
{
    Console.WriteLine("Buenas Tardes!");
}
else if (horaDelDía >= 19 && horaDelDía <= 23)
{
    Console.WriteLine("Buenas Noches!");
}
else
{
    Console.WriteLine("Ingrese una hora apropiada");
} 
