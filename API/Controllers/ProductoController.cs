namespace DefaultNamespace;

[ApiController]
[Route("api/productos")]
public class ProductosController : ControllerBase
{
    private readonly IProductoService _productoService;

    public ProductosController(IProductoService productoService)
    {
        _productoService = productoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetProductos([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var productos = await _productoService.GetAllProductos(pageNumber, pageSize);
        return Ok(productos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProducto(int id)
    {
        var producto = await _productoService.GetProductoById(id);
        if (producto == null)
        {
            return NotFound();
        }
        return Ok(producto);
    }

    [HttpPost]
    [Authorize]  
    public async Task<IActionResult> AddProducto([FromBody] ProductoDto productoDto)
    {
        var producto = new Producto
        {
            Nombre = productoDto.Nombre,
            Descripcion = productoDto.Descripcion,
            Precio = productoDto.Precio,
            ImagenUrl = productoDto.ImagenUrl,
            CategoriaId = productoDto.CategoriaId
        };

        await _productoService.AddProducto(producto);
        return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProducto(int id)
    {
        await _productoService.DeleteProducto(id);
        return NoContent();
    }
}
