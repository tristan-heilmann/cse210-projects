public class Customer

{
    // member variables
    private string _customerName;
    private Address _customerAddress;

    // constructor
    public Customer(string name, Address address)
    
    {
        _customerName = name;
        _customerAddress = address;
    }

    public bool IsCustomerInUS()

    {
        return _customerAddress.IsCustomerInUS();
    }

    public string GetCustomerName()

    {
        return _customerName;
    }

    // getting the shipping details
    public string GetCustomerAddress()

    {
        return _customerAddress.DisplayAddressDetails();
    }
}