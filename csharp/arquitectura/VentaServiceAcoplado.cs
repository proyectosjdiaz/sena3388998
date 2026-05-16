// ❌ Acoplado: el servicio fabrica su propio repositorio
public class VentaServiceAcoplado
{
    private readonly VentaRepository _repo = new VentaRepository();
 
    public void Registrar(Venta venta)
    {
        _repo.Guardar(venta);
    }
}