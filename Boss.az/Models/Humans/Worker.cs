using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Xml.Linq;
namespace Boss.az.Models.Humans;

public class Worker
{
    public static int id = 0;
    private string _name;

	public string Name
	{
		get { return _name; }
		set { if (value.Length < 3 && value.Length > 19) throw new Exception("name length must [3;19]"); _name = value; }
	}

    private string _surname;

    public string Surname
    {
        get { return _surname; }
        set { if (value.Length < 3 && value.Length > 19) throw new Exception("surname length must [3;19]"); _surname = value; }
    }

    private string _sheher;

    public string Sheher
    {
        get { return _sheher; }
        set { if (value.Length < 3 && value.Length > 19) throw new Exception("Sheher length must [3;19]"); _sheher = value; }
    }

    private string _phone;

    public string Phone
    {
        get { return _phone; }
        set { if (!(value.Length == 10)) throw new Exception("Phone must be 10 characters"); _phone = value; }
    }
    private int _age;

    public int Age
    {
        get { return _age; }
        set { if (_age <= 18 && _age >= 55) throw new Exception("Age must [18;55]"); else _age = value; }
    }
    public CV cv{ get; set; }

    public Worker(string name, string surname, string sheher, string phone, int age, CV cv):this()
    {
        Name = name;
        Surname = surname;
        Sheher = sheher;
        Phone = phone;
        Age = age;
        this.cv = cv;
    }

    public Worker()
    {
        id++;
        _age = 0;
        _name = string.Empty;
        _sheher = string.Empty;
        _phone = string.Empty;
        _surname = string.Empty;
        this.cv = new CV();
    }

    public override string ToString()
    {
        return $"{Name} {Surname} {Age} {Sheher} {Phone}" + cv.ToString();
    }
}
