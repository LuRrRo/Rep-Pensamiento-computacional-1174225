
Medicamento [] medicamentos = new Medicamento[6]; 
medicamentos[0]=new Medicamento{codigo = "000", nombre = "Aspirina", inventario = 50, precio = 2};
medicamentos[1]=new Medicamento{codigo = "001", nombre = "Diclofenaco", inventario = 45, precio = 5};
medicamentos[2]=new Medicamento{codigo = "002", nombre = "Pasiflora", inventario = 12, precio = 3};
medicamentos[3]=new Medicamento{codigo = "003", nombre = "Paracetamol", inventario = 20, precio = 7};
medicamentos[4]=new Medicamento{codigo = "004", nombre = "Sukrol", inventario = 10, precio = 4};
medicamentos[5]=new Medicamento{codigo = "005", nombre = "Gripetin", inventario = 8, precio = 12};

void mostrarInfo()
{
   for (int i = 0; i < medicamentos.Length; i++)
   {
        Console.WriteLine($"CODIGO: {medicamentos[i].codigo} NOMBRE: {medicamentos[i].nombre} INVENTARIO: {medicamentos[i].inventario} PRECIO: {medicamentos[i].precio}");
   } 
}

mostrarInfo();
public struct Medicamento
{
    public string codigo;
    public string nombre;
    public int inventario;
    public int precio;

    
}
