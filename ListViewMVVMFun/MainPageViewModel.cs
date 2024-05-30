using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ListViewMVVMFun;
internal partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _result = false;

    [ObservableProperty]
    private List<Person> _people;

    public MainPageViewModel()
    {
        _people = [
            new Person(1,"asd",10),
            new Person(2,"qwe",20),
            new Person(3,"zxc",30),
            new Person(4,"rty",40),
        ];
    }

    [RelayCommand]
    private void Do(Person person)
    {
        if (person.Age > 18)
        {
            Result = true;
        }
        else
        {
            Result = false;
        }
    }
}

class Person
{
    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
