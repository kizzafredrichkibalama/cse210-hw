using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public double GetTotalCost()
    {
        double totalProductCost = 0;

        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        return totalProductCost + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";
        label += "==============\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += "===============\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();

        return label;
    }
}
