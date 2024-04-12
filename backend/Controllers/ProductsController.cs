using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private List<Product> _products = new List<Product>();

    public ProductsController()
    {
        // Sample data
        _products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Description 1", Price = 10.99m });
        _products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Description 2", Price = 20.99m });
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_products);
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        if (product == null)
            return BadRequest("Product is null");

        product.Id = Guid.NewGuid();
        _products.Add(product);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(Guid id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(Guid id, Product product)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Id == id);
        if (existingProduct == null)
            return NotFound();

        existingProduct.Name = product.Name;
        existingProduct.Description = product.Description;
        existingProduct.Price = product.Price;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(Guid id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();

        _products.Remove(product);
        return NoContent();
    }
}
