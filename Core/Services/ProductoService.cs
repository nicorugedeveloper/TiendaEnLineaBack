namespace DefaultNamespace;

public class ProductoService : IProductoService
{
    private readonly IProductoRepository _productoRepository;

    public ProductoService(IProductoRepository productoRepository)
    {
        _productoRepository = productoRepository;
    }

    public async Task<IEnumerable<Producto>> GetAllProductos(int pageNumber, int pageSize)
    {
        return await _productoRepository.GetAll()
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<Producto> GetProductoById(int id)
    {
        return await _productoRepository.GetById(id);
    }

    public async Task AddProducto(Producto producto)
    {
        await _productoRepository.Add(producto);
    }

    public async Task DeleteProducto(int id)
    {
        await _productoRepository.Delete(id);
    }

    public async Task<IEnumerable<Producto>> GetProductosByCategoria(int categoriaId)
    {
        return await _productoRepository.GetByCategoria(categoriaId);
    }
}
