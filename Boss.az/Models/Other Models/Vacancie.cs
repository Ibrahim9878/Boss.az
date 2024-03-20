using System.Text.RegularExpressions;

namespace Boss.az.Models.Other_Models;

public class Vacancie
{
    public static int id = 0;
	private string _name;

	public string Name
	{
        get { return _name; }
        set { if (value.Length < 3 && value.Length > 19) throw new Exception("Vacancie name length must [3;16]"); _name = value; }
    }

	private string _information;

	public string Information
	{
		get { return _information; }
		set { if (Regex.IsMatch(value, "^.{1,1000}$")) _information = value; else throw new Exception("Information is wrong"); }
	}

	private string _requirement;
	public string Requirement { get => _requirement; set { if (Regex.IsMatch(value, "^.{1,1000}$")) _requirement = value; else throw new Exception("Requirement is wrong"); } }

	public int salary { get; set; }
	public int WorkingTime { get; set; }

	
    public Vacancie()
    {
        _name = string.Empty;
        _information = string.Empty;
        _requirement = string.Empty;
        salary = 0;
        WorkingTime = 0;
    }
    public Vacancie(string name, string information, string requirement, int salary, int workingTime)
    {
        Name = name;
        Information = information;
        Requirement = requirement;
        this.salary = salary;
        WorkingTime = workingTime;
    }

}
