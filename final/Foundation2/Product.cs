public class Product

{
    // member variables
    private string _productName;
    private string _productID;
    private float _productPrice;
    private int _productQuantity;

    // constructor
    public Product() {}

    public void SetProductName()

    {
        Console.Write("What is the product's name? ");
        _productName = Console.ReadLine();
    }

    public string GetProductName()

    {
        return _productName;
    }

    public void SetProductID()

    {
        string _idNumber = "";

        Random random = new();

        for (int i = 0; i < 8; i++)

        {
            _idNumber += random.Next(9);
        }

        _productID = $"#{_idNumber}";
    }

    public string GetProductID()

    {
        SetProductID();
        return _productID;
    }

    public void SetProductPrice()

    {
        Console.Write("What is the price of the item? ");
        _productPrice = float.Parse(Console.ReadLine());
    }

    public float GetProductPrice()

    {
        return _productPrice;
    }

    public void SetProductQuantity()

    {
        Console.Write("How many of the item do you have? ");
        _productQuantity = int.Parse(Console.ReadLine());
    }

    public float GetProductQuantity()

    {
    return _productQuantity;
    }

    // calculating price 
    public float CalculateFullProductPrice()

    {
        return _productPrice * _productQuantity;
    }
}