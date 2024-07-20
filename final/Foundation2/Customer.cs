public class Customer

{
    // member variables
    private string _customerName;
    private Address _customerAddress;

    // constructor
    public Customer() {}

    // getting the customers name
    public void SetCustomerName()

    {
        Console.Write("What is your name? ");
        _customerName = Console.ReadLine();
    }

    public string GetCustomerName()

    {
        return _customerName;
    }

    // getting the customer's location
    public void CustomerLocation()

    {
        Console.Write("Where are you from? ");
        string country = Console.ReadLine();
        
        _customerAddress.IsCustomerLocationUS(country);
    }

    // getting the shipping details
    public void GetShipping()

    {
        _customerAddress.DisplayAddressDetails();
    }
}