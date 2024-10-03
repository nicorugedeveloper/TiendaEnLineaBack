namespace Core.Entities;

public class ProductoDeseado
{
    public int Id { get; set; }
    public int UsuarioId { get; set; } 
    public int ProductoId { get; set; }
    public Producto Producto { get; set; }
}
