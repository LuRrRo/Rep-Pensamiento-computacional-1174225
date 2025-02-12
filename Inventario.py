import pickle, os

existidor=os.path.exists("Productos.pk1")

productos=[]

def agregar_producto(nombre,cantidad,precio):
    x={
        "Nombre":nombre,
        "Stock":cantidad,
        "Precio":precio
        }
    productos.append(x)

    print("El producto se añadio con exito.")

def mostrar_productos():
    for elemento in productos:
        valores=[]
        for valor in elemento.values():
            valores.append(valor)
        print(f"Nombre: {valores[0]} --Stock: {valores[1]} --Precio: {valores[2]}")

def buscar_producto(nombre_p):
    nombre=""
    
    for dict in productos:
        if dict["Nombre"] == nombre_p:
            nombre=dict
            break
    
    if nombre == "":
        return "No se encontro el producto que buscaba."
    elif nombre != "":
        return f"{nombre}"

def guardar():
    with open("Productos.pk1","wb") as archivo:
        pickle.dump(productos,archivo)
    print("Los productos se guardaron con exito")

print("Tienda Galindo")
if existidor == True:
    with open("Productos.pk1","rb") as archivo:
        p_cargados=pickle.load(archivo)
        for item in p_cargados:
            productos.append(item)
elif existidor == False:
    print("Aun no hay inventario")

print("1. Agregar productos")
print("2. Mostrar productos")
print("3. Buscar producto")
print("4. Guardar productos")
print("5. Salir")

d=int(input("Seleccione una opcion: "))
while d!=5:
    if d==1:
        print("Selecciono: Agregar producto")
        np=input("¿Cual es el nombre del producto? ")
        sp=int(input("¿Cuantos elementos de este ingresan a la tienda? "))
        pp=float(input("¿Cuanto cuesta cada unidad? "))
        agregar_producto(np,sp,pp)
        d=int(input("Seleccione otra opcion: "))
    elif d==2:
        print("Selecciono: Mostrar productos")
        try:
            mostrar_productos()
        except Exception as e:
            print(f"Error: {e}")
        d=int(input("Seleccione otra opcion: "))
    elif d==3:
        print("Selecciono: Buscar producto")
        mmm=input("¿Que producto desea buscar? ")
        try:
            print(buscar_producto(mmm))
        except Exception as e:
            print(f"Error: {e}")
        d=int(input("Seleccione otra opcion: "))
    elif d==4:
        guardar()
        d=int(input("Seleccione otra opcion: "))
    elif d==5:
        exit()




