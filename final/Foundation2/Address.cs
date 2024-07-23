public class Address

{
    // member variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)

    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // street address getter
    public string GetStreetAddress()

    {
        return _streetAddress;
    }

    // city getter
    public string GetCity()

    {
        return _city;
    }

    // state/province getter
    public string GetState()

    {
        return _state;
    }

    // country getter
    public string GetCountry()

    {
        return _country;
    }

    // this connects to Order and sets the shipping cost
    public bool IsCustomerInUS()

    {
        if (_country.ToLower() == "usa")

        {
            return true;
        }

        else
        
        {
            return false;
        }
    }

    // displays the address
    public string DisplayAddressDetails()

    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}