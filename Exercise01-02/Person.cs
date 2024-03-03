class Person {
    private string name;
    private string lastName;
    private int age;
    private List<Address> addresses;
    private List<string> emailAddresses;
    private List<string> phoneNumbers;

    public Person(string name, string lastName, int age, List<Address> addresses, List<string> emailAddresses, List<string> phoneNumbers)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.addresses = addresses ?? new List<Address>();
            this.emailAddresses = emailAddresses ?? new List<string>();
            this.phoneNumbers = phoneNumbers ?? new List<string>();
        }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string LastName {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age {
        get { return age; }
        set { age = value; }
    }

    public List<Address> Addresses {
        get { return addresses; }
        set { addresses = value; }
    }

    public List<string> EmailAddresses {
        get { return emailAddresses; }
        set { emailAddresses = value; }
    }

    public List<string> PhoneNumbers {
        get { return phoneNumbers; }
        set { phoneNumbers = value; }
    }

    public void AddAddress(Address address)
    {
        Addresses.Add(address);
    }

    public void AddEmailAddress(string emailAddress)
    {
        EmailAddresses.Add(emailAddress);
    }

    public void AddPhoneNumber(string phoneNumber)
    {
        PhoneNumbers.Add(phoneNumber);
    }

    
    public override string ToString()
    {
        var addressString = string.Join("\n", Addresses.Select(a => a.ToString()));
        var emailString = string.Join(", ", EmailAddresses);
        var phoneString = string.Join(", ", PhoneNumbers);

        return $"Person Information:\nName: {Name}\nLast Name: {LastName}\nAge: {Age}\nAddresses:\n{addressString}\nEmail Addresses:\n{emailString}\nPhone Numbers:\n{phoneString}\n";
    }

    public void PersonInfo()
    {
        Console.WriteLine(ToString());  
    } 
}