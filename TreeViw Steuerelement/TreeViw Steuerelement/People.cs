using System.Collections.Generic;

namespace TreeViw_Steuerelement;

public class People
{

    public People()
    {
        Person = new List<Person>();
    }
    
    public List<Person> Person { get; set; }
    public string Category { get; set; }
}