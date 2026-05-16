// En Program.cs (quien arma todo)
var repo = new VentaMemoryRepository();
var servicio = new VentaService(repo);
servicio.Registrar(nuevaVenta);
