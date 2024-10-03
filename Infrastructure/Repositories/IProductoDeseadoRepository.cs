namespace DefaultNamespace;

public interface IProductoDeseadoRepository
{
    Task<IEnumerable<ProductoDeseado>> GetAllByUser(int userId);
    Task Add(ProductoDeseado productoDeseado);                 
    Task Delete(int productoDeseadoId);
}
