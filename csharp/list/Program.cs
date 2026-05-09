using System.Collections.Generic;
 
// Lista tipada, vacía al inicio
List<Producto> productos = new();
 
productos.Add(new Producto("Teclado", 180000m));
productos.Add(new Producto("Mouse", 75000m));
productos.Add(new Producto("Monitor", 650000m));
 
Console.WriteLine($"Total productos: {productos.Count}");
 
// Eliminar por referencia (por ejemplo, el primero)
productos.Remove(productos[0]);
 
// Recorrido (sin detenernos en la sintaxis del ciclo)
foreach (var p in productos)
{
    p.MostrarInformacion();
}

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
 
    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
 
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Nombre} - Precio: {Precio:C}");
    }
}
