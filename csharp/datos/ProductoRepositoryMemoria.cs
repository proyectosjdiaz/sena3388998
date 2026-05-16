// Implementación 1: en memoria (la que usamos hoy)
public class ProductoRepositoryMemoria : IProductoRepository
{
    private readonly List<Producto> _productos = new();
 
    public void Agregar(Producto producto) => _productos.Add(producto);
 
    public Producto BuscarPorId(int id) =>
        _productos.FirstOrDefault(p => p.Id == id);
 
    public List<Producto> Listar() => _productos;
}
