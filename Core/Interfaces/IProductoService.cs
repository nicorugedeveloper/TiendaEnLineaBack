namespace DefaultNamespace;

public interface IProductoService
{
    Task<IEnumerable<Producto>> GetAllProductos(int pageNumber, int pageSize);  
    Task<Producto> GetProductoById(int id);
    Task AddProducto(Producto producto);
    Task DeleteProducto(int id);
    Task<IEnumerable<Producto>> GetProductosByCategoria(int categoriaId);
}
