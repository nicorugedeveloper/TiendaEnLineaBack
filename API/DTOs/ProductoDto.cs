namespace DefaultNamespace;

public class ProductoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public string ImagenUrl { get; set; } 
    public int CategoriaId { get; set; }
}
