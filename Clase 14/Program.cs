
/*Console.WriteLine("Notas de estudiantes");
string[] estudiantes = {"Juan","Pedro", "Luisa","Adriana","Sofia"};
int [] nota = {88, 75, 96, 77, 59};
int promedio = 0;
for (int i = 0; i < estudiantes.Length; i++)
{
    Console.WriteLine($"{estudiantes[i]} - {nota[i]}");    
    promedio += nota[i];
}
promedio /= estudiantes.Length;
Console.WriteLine($"El promedio de los estudiantes es de {promedio}");*/
static string numALetra(int numero)
    {
        string almacenador;
        char[] abecedario = {'A', 'B', 'C', 'D', 'E', 'F', 'G','H', 'I', 'J', 'K', 'L', 'M', 'N','O', 'P', 'Q', 'R', 'S', 'T', 'U','V', 'W', 'X', 'Y', 'Z'};
        almacenador = Convert.ToString(abecedario[numero]);
        return almacenador;
    }

static void mostrarMatrizVisual( string [,] matrizR)
    {
        for (int i = 0; i < matrizR.GetLength(0); i++)
        {
            string almacenador = "[";
            for (int j = 0; j < matrizR.GetLength(1); j++)
            {
                almacenador +=  " "+numALetra(i) + Convert.ToString(j+1)+" ";
            }
            almacenador += "]";
            Console.WriteLine(almacenador);
        }
    }


string [,] mimatriz = new string [4,5];

mostrarMatrizVisual(mimatriz);

