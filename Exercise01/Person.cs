class Person {
    private string Name;
    private string LastName;
    private int Age;

    private string Address;
    private string Email;
    private string Phone;

    public Person(string name, string lastName, int age, string address, string email, string phone) {
        Name = name;
        LastName = lastName;
        Age = age;
        Address = address;
        Email = email;
        Phone = phone;
    }

    public void PersonInfo() {
        Console.WriteLine($"Person Information:\nName: {Name}\nLast Name: {LastName}\nAge: {Age}\nAddress: {Address}\nEmail: {Email}\nPhone: {Phone}\n");
    }
} 