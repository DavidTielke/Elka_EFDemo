﻿namespace EFDemo1.DataClasses;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual IList<PersonTag> PersonTags { get; set; }
}