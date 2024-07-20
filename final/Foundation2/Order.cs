using System.Numerics;

public class Order

{
    // member variables
    private List<Product> products;
    private  List<Customer> customers;
    private float _totalCost;
    private int _shippingCost;
    private int _isUS;
    private int _isNotUS;

    // constructor
    public Order()

    {
        products = new List<Product>();
        customers = new List<Customer>();

        _isUS = 5;
        _isNotUS = 35;
    }

    public void GetPackingLabel()

    {
        Console.WriteLine("Packing label:");

        foreach (Product product in products)

        {
            Console.WriteLine($"Item name and ID: {product.GetProductName} - {product.GetProductID}");
        }
    }

    public void GetShippingLabel()

    {
        foreach (Customer customer in customers)

        {
            
        }
    }

    public float CalulateTotalCost()

    {
        foreach (Product product in products)

        {
            _totalCost += product.CalculateFullProductPrice();
        }

        return _totalCost + GetShippingCost();
    }

    public float GetTotalCost()

    {
        return _totalCost;
    }

    public int GetShippingCost()

    {
        return _shippingCost;
    }
}