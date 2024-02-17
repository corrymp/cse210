class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;

    public Address(string street, string city, string stateProvince)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}";
    }
}