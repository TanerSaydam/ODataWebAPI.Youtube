using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using ODataWebAPI.Context;
using ODataWebAPI.Dtos;
using ODataWebAPI.Models;

namespace ODataWebAPI.Controllers;
[Route("odata")]
[ApiController]
[EnableQuery]
public sealed class MyTestController(
    ApplicationDbContext context) : ODataController
{
    public static IEdmModel GetEdmModel()
    {
        ODataConventionModelBuilder builder = new();
        builder.EnableLowerCamelCase();
        builder.EntitySet<Category>("categories");
        builder.EntitySet<Product>("products");
        builder.EntitySet<ProductDto>("products-dto");
        builder.EntitySet<UserDto>("users");
        return builder.GetEdmModel();
    }

    #region Categories
    [HttpGet("categories")]
    //[EnableQuery(AllowedQueryOptions = AllowedQueryOptions.Top | AllowedQueryOptions.Select | AllowedQueryOptions.Filter)]
    //[EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All & ~AllowedQueryOptions.Select)]
    public IQueryable<Category> Categories()
    {
        var categories = context.Categories.AsQueryable();

        return categories;
    }
    #endregion

    #region Products
    [HttpGet("products")]
    public IQueryable<Product> Products()
    {
        var response = context.Products.AsQueryable();
        return response;
    }
    #endregion

    #region Products
    [HttpGet("products-dto")]
    public IQueryable<ProductDto> ProductsDto()
    {
        var response = context.Products.Select(s => new ProductDto
        {
            Id = s.Id,
            Name = s.Name,
            Price = s.Price,
            CategoryName = s.Category != null ? s.Category.Name : ""
        }).AsQueryable();
        return response;
    }
    #endregion

    #region Users
    [HttpGet("users")]
    public IActionResult Users()
    {
        var users = context.Users
            .Select(s => new UserDto
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                FullName = s.FullName,
                Address = s.Address,
                Id = s.Id,
                UserType = s.UserType,
                UserTypeName = s.UserType.Name,
                UserTypeValue = s.UserType.Value
            })
            .AsQueryable();
        return Ok(users);
    }
    #endregion
}