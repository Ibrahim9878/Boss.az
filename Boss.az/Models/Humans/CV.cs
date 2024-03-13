namespace Boss.az.Models.Humans;

public class CV
{
	private string _profession;
	public string Profession
	{
		get { return _profession; }
		set { if (value.Length < 3 && value.Length > 19) throw new Exception("profession length must [3;19]"); _profession = value; }
	}
	private string _school;

	public string School
	{
		get { return _school; }
		set { if (value.Length < 3 && value.Length > 15) throw new Exception("school length must [3;15]"); _profession = value; }
	}

	private string _skills;

	public string Skills
	{
		get { return _skills; }
		set { if (value.Length < 3 && value.Length > 19) throw new Exception("profession length must [3;19]"); _skills = value; }
	}
	public Dictionary<char,int> LevelOfLanguage { get; set; }


	private List<string> Companies { get; set; }
	public DateTime StartDateTime { get; set; }
	public DateTime EndDateTime { get; set; }

	private int _languageCount;

	public int LanguageCount
	{
		get { return _languageCount; }
		set { if (value < 0) throw new Exception("Language cant be negative"); _languageCount = value; }
	}
	public bool HasCertification { get; set; }

    public CV(string profession,  string school, string skills, List<string> companies, int languageCount, bool hasCertification, DateTime date1, DateTime date2, Dictionary<char,int> levelOfLanguage)
    {
        _profession = profession;
        _school = school;
        _skills = skills;
        Companies = companies;
        _languageCount = languageCount;
        HasCertification = hasCertification; 
        StartDateTime = date1;
        EndDateTime = date2;
        LevelOfLanguage = levelOfLanguage;
    }
    public CV()
    {
        Companies = new List<string>();
        _profession = string.Empty;
        _school = string.Empty;
        _skills = string.Empty;
        _languageCount = 0;
        HasCertification = false;
		LevelOfLanguage = new();
    }
    public override string ToString()
    {
		string message = "";
		foreach (var item in Companies)
		{
			message += item;
			message += ", ";
		}
		string text = "";
		foreach (var item in LevelOfLanguage)
		{
			text += item.Key+" " + item.Value +"\n";

		}
        return $"{Profession} {School} {Skills} {StartDateTime} {EndDateTime} {LanguageCount} {HasCertification} {message} {text}" ;
    }

}

