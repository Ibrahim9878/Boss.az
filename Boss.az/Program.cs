using Boss.az.Models.Functions;
using Boss.az.Models.Humans;
using Boss.az.Models.Other_Models;

Console.WriteLine("Hello, World!");
try
{
    Vacancie v1 = new Vacancie("Ibrahim", "Ibrhaim", "hjdvjhdsv", 700, 7);
    Vacancie v2 = new Vacancie("Ibrahim", "Ibrhaim", "hjdvjhdsv", 700, 7);
    Vacancie v3 = new Vacancie("Ibrahim", "Ibrhaim", "hjdvjhdsv", 700, 7);
    List<Vacancie> vs = new();
    vs.Add(v1);
    vs.Add(v2);
    vs.Add(v3);
    Employer employer = new Employer("Ibrahim", "Talibli", "Baku", "+994515959757", 22, "talibliibrahim28@gmail.com", vs);
    Employer employer2 = new Employer("Ibrahim", "Talibli", "Baku", "+994515959757", 22, "talibliibrahim28@gmail.com", vs);
    Database.employers.Add(employer);
    Database.employers.Add(employer2);
    Database.WriteEmployersToJson();
    Database.WriteVacanciesToJson();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
};
Functions.FirstMenu();