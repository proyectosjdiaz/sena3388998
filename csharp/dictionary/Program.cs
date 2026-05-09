// Diccionario: clave = Id del producto, valor = nombre
Dictionary<int, string> productos = new();
 
productos.Add(1, "Teclado");
productos.Add(2, "Mouse");
productos.Add(3, "Monitor");
 
// Búsqueda por clave (rápida y directa)
if (productos.ContainsKey(2))
{
    Console.WriteLine($"Producto 2: {productos[2]}");
}
 
// Recorrido
foreach (var kv in productos)
{
    Console.WriteLine($"{kv.Key} -> {kv.Value}");
}
