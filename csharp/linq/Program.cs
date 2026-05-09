using System.Linq;
 
List<Producto> productos = new()
{
    new Producto("Teclado", 180000m),
    new Producto("Mouse", 75000m),
    new Producto("Monitor", 650000m),
    new Producto("USB", 25000m),
};
 
// Filtrar productos "caros"
var caros = productos.Where(p => p.Precio > 100000m);
 
foreach (var p in caros)
{
    p.MostrarInformacion();
}
 
// Obtener solo los nombres
var nombres = productos.Select(p => p.Nombre).ToList();
 
// Contar cuántos productos cuestan más de 100.000
int cantidadCaros = productos.Count(p => p.Precio > 100000m);


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
