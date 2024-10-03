namespace DefaultNamespace;

public interface IProductoRepository
{
    Task<IEnumerable<Producto>> GetAll();                  
    Task<Producto> GetById(int id);                        
    Task Add(Producto producto);                           
    Task Delete(int id);                                   
    Task<IEnumerable<Producto>> GetByCategoria(int categoriaId);  
}
