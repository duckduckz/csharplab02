class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Jane", "Smith", 25, new List<Address>(), new List<string>(), new List<string>());

        person.AddAddress(new Address("456 Elm St", "Apt 7C", "54321", "Sampletown", "Countryland"));
        person.AddAddress(new Address("789 Oak St", "House 12", "65432", "Anothercity", "Countryville"));

        person.AddEmailAddress("jane.smith@example.com");
        person.AddEmailAddress("j.smith@emailprovider.net");

        person.AddPhoneNumber("(987) 654-3210");
        person.AddPhoneNumber("(123) 456-7890");

        person.PersonInfo();
    }
}
