public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool AddressAmericanOrNot()
    {
        if (_country == "USA" || _country == "United States" || _country == "America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayCustomerAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}. {_country}";
    }

   
}