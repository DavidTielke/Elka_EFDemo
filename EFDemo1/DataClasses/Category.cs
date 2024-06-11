namespace EFDemo1.DataClasses;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual IList<Person> Persons { get; set; }
}