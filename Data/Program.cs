/*Caio Guilherme Ferreira da Silva
 * Student ID: 30099789
 *v0.1 2021-05-26
 *Description: This program is a console application that creates a list of people with missing values, 
 *duplicate emails, and different date formats. The program will handle the missing values by replacing them with the average age of the list,
 *remove duplicate emails, and standardize the date format to yyyy-MM-dd. The program will display the list of people with the corrected values.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Person class that contains the properties Name, Age, Email, and Birth.
/// </summary>
class Person
{
    //Properties
    public string Name { get; set; }
    public object Age { get; set; }
    public string Birth { get; set; }
    public string Email{ get; set; }
    public Person(string name, object age, string email, string birth)
    {
        Name = name;
        Age = age;
        Email = email;
        Birth = birth;
        
    }
}
class Program
{
    static void Main()
    {
        //Create a list of people with missing values, duplicate emails, and different date formats.
        List<Person> people = new List<Person>();
        people.Add(new Person("Alice", 30, "alice@example.com", "12/31/1990"));
        people.Add(new Person("Bob", null, "bob@example.com", "01-15-1985"));
        people.Add(new Person("Charlie", 25, "charlie@example.com", "1992-03-20"));
        people.Add(new Person("Alice", 30, "alice@example.com", "12/31/1990"));
        people.Add(new Person("Eve", 29, "eve@example.com", "1988/06/12"));
        people.Add(new Person("Frank", null, "frank@example.com", "09.25.1990"));
        HandleMissingValues(people);//Handle missing values
        people = RemoveDuplicateEmails(people);//Remove duplicate emails
        StandardizeDates(people);//Standardize date format
        DisplayPeople(people);//Display people list
    }
    /// <summary>
    /// Handle missing values by replacing them with the average age of the list.
    /// </summary>
    /// <param name="people">List of indiviualsList of individuals and their datas</param>
    static void HandleMissingValues(List<Person> people)
    {
        //Calculate the average age of the list
        int avgAge = (int)people.Where(p => p.Age != null).Average(p => (int)p.Age);
        foreach (Person person in people)//Replace missing values with the average age
        {
            if (person.Age == null)
            {
                person.Age = avgAge;
            }
        }
    }
    /// <summary>
    /// Remove duplicate emails from the list.
    /// </summary>
    /// <param name="people">List of individuals and their datas</param>
    /// <returns>List without duplicate datas</returns>
    static List<Person> RemoveDuplicateEmails(List<Person> people)
    {
        List<Person> distinctPeople = new List<Person>();
        foreach (Person person in people)//Add distinct people to the list
        {
            if (!distinctPeople.Any(p => p.Email == person.Email))
            {
                distinctPeople.Add(person);
            }
        }
        return distinctPeople;
    }
    /// <summary>
    /// Standardize the date format to yyyy-MM-dd.
    /// </summary>
    /// <param name="people">List of individuals and their data</param>
    static void StandardizeDates(List<Person> people)
    {
        string[] formats = { "MM/dd/yyyy", "MM-dd-yyyy", "yyyy-MM-dd", "yyyy/MM/dd", "MM.dd.yyyy", "MM.dd.yyyy" };
        foreach (Person person in people)//Standardize date format
        {
            DateTime date;
            if (DateTime.TryParseExact(person.Birth, formats, null, System.Globalization.DateTimeStyles.None, out date))//Try to parse the date
            {
                person.Birth = date.ToString("yyyy-MM-dd");
            }
        }
    }
    /// <summary>
    /// Display the list of people with the corrected values.
    /// </summary>
    /// <param name="people">List of individuals and their data</param>
    static void DisplayPeople(List<Person> people)
    {
        Console.WriteLine("People List");
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}\nAge: {person.Age}\nEmail: {person.Email}\nBirth: {person.Birth}\n");
        }

    }
}
