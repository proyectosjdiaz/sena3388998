public class Venta
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public Producto Producto { get; set; }
    public DateTime Fecha { get; set; }
 
    public Venta(int id, Cliente cliente, Producto producto, DateTime fecha)
    {
        Id = id;
        Cliente = cliente;
        Producto = producto;
        Fecha = fecha;
    }
}