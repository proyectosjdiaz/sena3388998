public interface IProductoRepository
{
    void Agregar(Producto producto);
    Producto BuscarPorId(int id);
    List<Producto> Listar();
}
