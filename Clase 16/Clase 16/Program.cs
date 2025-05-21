Console.WriteLine("Bienvenido, ingrese los datos del cilindro \nRadio:");
double vradio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Altura:");
double valtura = Convert.ToDouble(Console.ReadLine());
Cilindro miCilindro = new Cilindro(vradio,valtura);
miCilindro.getVolumen();

class Cilindro
{
    public double radio;
    public double altura;

public Cilindro(double Radio, double Altura)
{
    this.radio = Radio;
    this.altura = Altura;
}
    public void getVolumen()
    {
        double volumen = Math.PI * altura * Math.Pow(radio,2);
        Console.WriteLine($"El volumen del cilindro es {volumen} unidades cubicas");
    }
}

