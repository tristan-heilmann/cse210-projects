public class Address

{
    // member variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;

    // constructor
    public Address(string streetAddress, string city, string state, string zipCode)

    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    // this is based on DisplayAddressDetails from Foundation2
    public string DisplayAddressDetails()

    {
        return $"{_streetAddress}, {_city}, {_state} {_zipCode}";
    }
}