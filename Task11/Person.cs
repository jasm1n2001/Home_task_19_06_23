public class Person 
{
    public string Name;
    public string Surname;
    public int Age;
    public string Aderes;

    public string FullName()
    {
        return $" my name is {Name} {Surname} ";
    }
    public string BirthYears()
    {
        return $"My birth year is {2023-Age}";
    }
}
