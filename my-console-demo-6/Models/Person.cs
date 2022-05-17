namespace my_console_demo_6.Models;


public static class MyExtensionMethods
{
    public static string FullName(this Person person, string separator)
    {
        return person.Name + " " + separator + " "+ person.Surname;
    }
}

public class Person
{
    //private string _id;
    //public string Id
    //{
    //    get { return _id; }
    //    set { _id = value; }
    //}

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty ;
    public int Age { get; init; }

    public void Eat()
    {

    }

    public void Sleep() { }


}
