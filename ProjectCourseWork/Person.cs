using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCourseWork
{
    // Enumeration defining roles
    public enum Role
    {
        Administration,
        TeachingStaff,
        Student
    }

    // Base class for all users
    public class Person
    {
        // Properties for basic user information
        public string Name { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Password { get; set; }
    }

    // Derived class for teaching staff
    public class Teacher : Person
    {
        // Additional properties specific to teachers
        public float Salary { get; set; }
        public List<string> Subjects { get; set; }

        public Teacher()
        {
            Subjects = new List<string>();
        }
    }

    // Derived class for administration staff
    public class Administration : Person
    {
        // Additional properties specific to administration staff
        public float Salary { get; set; }

        public string EmploymentType { get; set; }
        public string WorkingHours { get; set; }
    }

    // Derived class for students
    public class Student : Person
    {
        // Additional properties specific to students
        public List<string> CurrentSubject1 { get; set; }
        public List<string> CurrentSubject2 { get; set; }
        public List<string> PreviousSubject1 { get; set; }
        public List<string> PreviousSubject2 { get; set; }

        public Student()
        {
            // Initializing lists for subjects
            CurrentSubject1 = new List<string>();
            CurrentSubject2 = new List<string>();
            PreviousSubject1 = new List<string>();
            PreviousSubject2 = new List<string>();
        }
    }

    // Static class for managing persons
    public static class PersonManager
    {
        // List to store persons
        private static List<Person> persons = new List<Person>();

        // Property to access the list
        public static List<Person> Persons
        {
            get { return persons; }
        }

        // Method to add a person to the list
        public static void AddPerson(Person person)
        {
            Persons.Add(person);
        }

        // Method to remove a person from the list
        public static void RemovePerson(Person person)
        {
            Persons.Remove(person);
        }
    }
}
