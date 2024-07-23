public class Product

{
    // member variables
    private string _productName;
    private string _productID;
    private float _productPrice;
    private int _productQuantity;

    // constructor
    public Product() {}

    public string GetProductName()

    {
        return _productName;
    }

    public void SetProductID()

    {
        string _IDNumber = "";

        Random random = new();

        for (int i = 0; i < 8; i++)

        {
            _IDNumber += random.Next(9);
        }

        _productID = $"#{_IDNumber}";
    }

    public string GetProductID()

    {
        SetProductID();
        return _productID;
    }

    public float GetProductPrice()

    {
        return _productPrice;
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