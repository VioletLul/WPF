using System;
using System.Collections.ObjectModel;

namespace UpdateSourceTrigger;

public class PersonViewModel
{
    public ObservableCollection<Person> Persons { get; set; }

    private string? _personName;
    public string? PersonName 
    {
        get => _personName;
        set
        {
            _personName = value;
            AddDataToCollection(this, EventArgs.Empty);
        }
    }

    public PersonViewModel()
    {
        Persons = new ObservableCollection<Person>();

        var personA = new Person
        {
            Name = "Thorsten Hans"
        };

        var personB = new Person
        {
            Name = "Peter Bucher"
        };

        var personC = new Person
        {
            Name = "Jürgen Gutsch"
        };

        Persons.Add(personA);
        Persons.Add(personB);
        Persons.Add(personC);
    }

    private void AddDataToCollection(object sender, EventArgs e)
    {
        var person = new Person { Name = PersonName };
        Persons.Add(person);
    }
}