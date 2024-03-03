public class Address
{
    private string street;
    private string houseNumber;
    private string zipCode;
    private string city;
    private string country;

    public Address(string street, string houseNumber, string zipCode, string city, string country)
    {
        this.street = street;
        this.houseNumber = houseNumber;
        this.zipCode = zipCode;
        this.city = city;
        this.country = country;
    }

    public string Street {
        get { return street; }
        set { street = value; }
    }

    public string HouseNumber {
        get { return houseNumber; }
        set { houseNumber = value; }
    }

    public string ZipCode {
        get { return zipCode; }
        set { zipCode = value; }
    }

    public string City {
        get { return city; }
        set { city = value; }
    }

    public string Country {
        get { return country; }
        set { country = value; }
    }

    public override string ToString()
    {
        return $"{street} {houseNumber}, {zipCode}, {city}, {country}";
    }

    


}