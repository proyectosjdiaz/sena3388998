// Implementación 2 (futura): base de datos
// public class ProductoRepositorySql : IProductoRepository { ... }
public class ProductoRepositorySql : IProductoRepository
{
    private readonly string _connectionString;

    public ProductoRepositorySql(string connectionString)
    {
        _connectionString = connectionString;
    }

    //seudo implementacion para mostrar la idea, no es funcional
    public void Agregar(Producto producto)
    {
        // using significa que se cerrará la conexión automáticamente al finalizar el bloque
        // esta implemenacion es solo para mostrar la idea, no es funcional
        // ejemplo de cadena de conexión: "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
        using var connection = new SqlConnection(_connectionString);
        {
            // notar que la arroba indica que la base de datos espera un valor para cada parámetro, y el nombre del parámetro debe coincidir con el nombre usado en el comando SQL
            string query = "INSERT INTO Productos (Id, Nombre, Precio) VALUES (@Id, @Nombre, @Precio)";
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", producto.Id);
            command.Parameters.AddWithValue("@Nombre", producto.Nombre);
            command.Parameters.AddWithValue("@Precio", producto.Precio);

            connection.Open();
            command.ExecuteNonQuery();
        }
        // al salir del using, se cierra la conexion y se liberan los recursos asociados, incluso si ocurre una excepción durante la ejecución del bloque.
    }

    public Producto BuscarPorId(int id)
    {
        // Código para buscar el producto por ID en la base de datos
        return null; // Placeholder
    }

    public List<Producto> Listar()
    {
        // Código para listar todos los productos desde la base de datos
        return new List<Producto>(); // Placeholder
    }
}