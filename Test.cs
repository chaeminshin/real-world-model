using System;

using FacultyNs;
using DepartmentNs;
using StudentNs;

namespace ChaeminAssignment2
{
    public class Test
    {
       
        static void Main(string[] args)
        {
            Faculty computer = new Faculty("Computer", "Waterloo", "Conestoga", "Stuying for computer science.");
            Faculty business = new Faculty("Business", "Kitchener", "Conestoga", "Studying for Business.");
            Faculty health = new Faculty("Health", "Waterloo", "Conestoga", "Studying for health.");

            Department sqa = new Department("Software Quality Assurance and Test Engineering", computer);
            Department mobile = new Department("Mobile Solutions Development", computer);
            Department marketing = new Department("Marketing", business);
            Department accounting = new Department("Accounting", business);
            Department nursing = new Department("Nursing", health);

            Student student1 = new Student("Chaemin", 8731386);
            Student student2 = new Student("Nick", 1234567);
            Student student3 = new Student("Miracle", 3332222);

            student1.AddDepartment(sqa);        // Can be enrolled (Computer, Waterloo)
            student1.AddDepartment(nursing);    // Can be enrolled (Health, Waterloo)
            student3.AddDepartment(accounting); // Can be enrolled (Business, Kitchener)
            student2.AddDepartment(sqa);        // Can be enrolled (Computer, Waterloo)
            student1.AddDepartment(marketing);  // Can be enrolled (Business, Kitchener)
            student1.AddDepartment(mobile);     // Cannot be enrolled (Computer, Waterloo)
            student2.AddDepartment(marketing);  // Can be enrolled  (Business, Kitchener)
            student2.AddDepartment(accounting); // Cannot be enrolled (Business, Kitchener)
            student3.AddDepartment(mobile);     // Can be enrolled (Computer, Waterloo)
            student3.AddDepartment(mobile);     // Cannot be enrolled (Computer, Waterloo)
            student1.AddDepartment(accounting); // Cannot be enrolled (Business, Kitchener)
            student3.AddDepartment(nursing);    // Can be enrolled (Health, Waterloo)

            Console.WriteLine("=================================================================================================\n");
            Console.WriteLine("Print total number of the students in the department");
            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
            Console.WriteLine(sqa.GetTotalNumberInfo() + mobile.GetTotalNumberInfo() + marketing.GetTotalNumberInfo() + accounting.GetTotalNumberInfo() + nursing.GetTotalNumberInfo());
            
            Console.WriteLine("=================================================================================================\n");
            Console.WriteLine("Print all departments along the number of the students within the faculty");
            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
            Console.WriteLine(sqa + "\n" + mobile + "\n" + marketing + "\n" + accounting + "\n" + nursing);

            Console.WriteLine("=================================================================================================\n");
            Console.WriteLine("Print student’s information such as student’s name, ID, faculty name, university, and campus");
            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
            Console.WriteLine(student1.GetStudentInfo() + student2.GetStudentInfo() + student3.GetStudentInfo());
           
            Console.WriteLine("=================================================================================================\n");
            Console.WriteLine("Print all faculties in the campus with the students information");
            Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
            student1.makingFaculties();
            student2.makingFaculties();
            student3.makingFaculties();
            
            Student student = new Student();
            Console.WriteLine(student);
        }
    }
}
