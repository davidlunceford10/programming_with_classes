public class Address
{
    string _streetAddress;
    string _city;
    string _stateOrProvince;
    string _country;
    bool _isUSA;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        
    }

    public bool AddressAmericanOrNot()
    {
        if (_country != "USA" || _country != "United States" || _country != "America")
        {
            _isUSA = false;
        }
        else
        {
            _isUSA = true;
        }
        return _isUSA;

    }

    public string DisplayCustomerAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}. {_country}";
    }
}