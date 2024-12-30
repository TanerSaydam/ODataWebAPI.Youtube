namespace ODataWebAPI.Dtos;

public sealed class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string CategoryName { get; set; } = default!;
}
