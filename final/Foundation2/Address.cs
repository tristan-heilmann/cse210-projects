public class Address

{
    // member variables
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // constructor
    public Address(string streetAddress, string city, string stateOrProvince, string country)

    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
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
    public string GetStateOrProvince()

    {
        return _stateOrProvince;
    }

    // country getter
    public string GetCountry()

    {
        return _country;
    }

    // this connects to Order and depending on your answer chooses your shipping cost
    public bool IsCustomerLocationUS(string country)

    {
        if (country.ToLower() == "us")

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
        string _addressInfo = $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";

        return _addressInfo;
    }
}