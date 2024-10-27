using System.Security.Cryptography.X509Certificates;

namespace lab2.my_class;

public class Person
{
    private string name;
    public string Name { get { return name; } set { name = value + "TEST"; } }



    public Person() {
        name = "Test";
    }

    public Person(string name)
    {
        this.name = name;
    }

    public void Welcome()
    {
        Console.WriteLine($"witaj jestem {name}");
    }
    public void Welcome(string othername)
    {
        Console.WriteLine($"witaj {othername} jestem {name}");
    }

    public void Welcome(int othername)
    {
        Console.WriteLine($"witaj {othername} jestem {name}");
    }


    public static Person Create()
    {
        return new Person();
    }
    public static Person mapuser(user u)
    {
        return new Person(u.name);
    }

}
