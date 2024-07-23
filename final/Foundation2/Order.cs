using System.Numerics;

public class Order

{
    // member variables
    private List<Product> products;
    Customer customer;
    private float _totalCost;
    private int _shippingCost;

    // constructor
    public Order()

    {
        products = new List<Product>();
    }

    public void PackingLabel()

    {
        foreach (Product product in products)

        {
            Console.WriteLine("Packing label:");

            Console.WriteLine($"Item name and ID: {product.GetProductName} - {product.GetProductID}");
        }
    }

    public void ShippingLabel()

    {
        Console.WriteLine("Shipping lable:");

        
    }

    public float CalulateTotalCost()

    {
        foreach (Product product in products)

        {
            _totalCost += product.CalculateFullProductPrice();
        }

        return _totalCost + _shippingCost;
    }

    public float GetTotalCost()

    {
        return _totalCost;
    }

    public void GetShippingCost()

    {
        Double _shippingCost = customer.CustomerLocation() ? 5 : 35;
    }
}