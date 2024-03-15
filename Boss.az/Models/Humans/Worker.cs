﻿using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Xml.Linq;
using System.Text.RegularExpressions;
namespace Boss.az.Models.Humans;

public class Worker
{
    public Guid id { get; set; }
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
        set { if (Regex.IsMatch(value, "^\\+994(\\s?\\d){9}$\r\n")) _phone = value; else throw new Exception("phone number is wrong"); }
    }
    private int _age;

    public int Age
    {
        get { return _age; }
        set { if (_age <= 18 && _age >= 55) throw new Exception("Age must [18;55]"); else _age = value; }
    }
    public CV cv{ get; set; }

    private string _email;

    public string Email
    {
        get { return _email; }
        set { if (Regex.IsMatch(value, "\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Z|a-z]{2,}\\b\r\n")) _email = value; else throw new Exception("Email is wrong"); }
    }


    public Worker(string name, string surname, string sheher, string phone, int age, CV cv, string email) : this()
    {

        Name = name;
        Surname = surname;
        Sheher = sheher;
        Phone = phone;
        Age = age;
        this.cv = cv;
        Email = email;
    }

    public Worker()
    {
        id = Guid.NewGuid();
        _age = 0;
        _name = string.Empty;
        _sheher = string.Empty;
        _phone = string.Empty;
        _surname = string.Empty;
        this.cv = new CV();
        _email = string.Empty;
    }

    public override string ToString()
    {
        return $"{Name} {Surname} {Age} {Sheher} {Phone}" + cv.ToString();
    }
}
