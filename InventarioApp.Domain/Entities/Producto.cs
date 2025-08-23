namespace InventarioApp.Domain.Entities;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public int Stock { get; set; }
    public int StockMinimo { get; set; }
    public decimal PrecioCompra { get; set; }
    public decimal PrecioVenta { get; set; }
}
