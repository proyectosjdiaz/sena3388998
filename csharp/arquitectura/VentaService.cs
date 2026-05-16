public class VentaService
{
    private readonly VentaRepository _repo;
 
    public VentaService(VentaRepository repo)
    {
        _repo = repo;
    }
 
    public void Registrar(Venta venta)
    {
        _repo.Guardar(venta);
    }
}
