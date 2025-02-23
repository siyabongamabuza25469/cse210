using System;
using System.Collections.Generic;
using System.Dynamic;

namespace OnlineOrderingProject
{
public class Product
{
    static void Main(string[] args)
    {

    Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }

    private string productName;
    private int productID;
    private decimal productPrice;
    private int productQuantity;

    public string Name { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }
    }

public class Customer
{
    private string name;
    private Address address;

    public string Name { get; set; }
    public Address Address { get; set; }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}

public class Address
{
    private string Street;
    private string City;
    private string StateProvince;
    private string Country;

    public string street { get; set; }
    public string city { get; set; }
    public string stateProvince { get; set; }
    public string country { get; set; }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}

public class Order
{
    private List<Product> products;
    private Customer customer;
    
    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        return totalCost + (customer.IsInUSA() ? 5 : 35); // Shipping costs
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}

}
