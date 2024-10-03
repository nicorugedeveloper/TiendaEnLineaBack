namespace Core.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; } 
    public List<ProductoDeseado> ProductosDeseados { get; set; }
}
