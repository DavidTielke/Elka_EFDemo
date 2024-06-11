using EFDemo1.Data.Mappings;

namespace EFDemo1.DataClasses;

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public int FK_CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public virtual IList<PersonTag> PersonTags { get; set; }
}