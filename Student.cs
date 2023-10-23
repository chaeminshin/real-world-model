using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using DepartmentNs;

namespace StudentNs
{
	public class Student
	{
		private String name;
		private int id;
		private HashSet<Department> departments;

		static ArrayList faculties = new ArrayList();

		public Student()
        {

        }

		public Student(String name, int id)
        {
			this.name = name;
			this.id = id;
			this.departments = new HashSet<Department>(); 
		}

		public void AddDepartment(Department department)
		{
			HashSet<Department> tempDepartment = new HashSet<Department>();

			Department temp = new Department();
			temp = department;
			bool check = true;

			if (this.departments.Count != 0)
            {
				while (check)
				{
					foreach (Department dp in this.departments)
					{
						if (dp.Equals(department))
						{
							
							Console.WriteLine("--------------------------------------------------------------------------------------------");
							Console.WriteLine(this.name + " (" + id + ") cannot be enrolled\n");
							Console.WriteLine(department);
							Console.WriteLine("The student already has enrolled another (or same) department of the same faculty");
							Console.WriteLine("--------------------------------------------------------------------------------------------");
							
							check = false;
                        }
					}
					if (check == true)
					{
						tempDepartment.Add(department);
						temp.NextNumber();
						check = false;
					}
                  
				}
				
			}   
			else
            {
				tempDepartment.Add(department);
				temp.NextNumber();
			}
			this.departments.UnionWith(tempDepartment);
		}

		public String GetStudentInfo()
        {
			StringBuilder result = new StringBuilder();
			result.Append("* Student Name: " + this.name + ", Student ID: " + this.id + "\n\n");
			foreach (Department department in this.departments)
			{
				result.Append("- Faculty Name: " + department.GetFaculty().GetName() + "\n");
				result.Append("- Campus: " + department.GetFaculty().GetCampus() + "\n");
				result.Append("- University: " + department.GetFaculty().GetUniversity() + "\n\n");
			}
			return result.ToString();
		}

		public void makingFaculties()
        {
			
			foreach (Department department in this.departments)
			{
				ArrayList al = new ArrayList();
				if (faculties.Count == 0)
                {
					al.Add(department.GetFaculty().GetCampus());
					al.Add(department.GetFaculty().GetName());
					al.Add(this.name + ", " + this.id.ToString() + ", " + department.GetName());

					faculties.Add(al);
				}
				else
                {
					bool check = false;
					for(int i=0; i<faculties.Count; i++)
                    {
						ArrayList temp = faculties[i] as ArrayList;
                        if (temp[0].Equals(department.GetFaculty().GetCampus()) && temp[1].Equals(department.GetFaculty().GetName()))
                        {
							temp.Add(this.name + ", " + this.id.ToString() + ", " + department.GetName());
							//temp.Add(department.ToString());
							check = true;
                        }
						
					}
					if(check == false)
                    {
						al.Add(department.GetFaculty().GetCampus());
						al.Add(department.GetFaculty().GetName());
						al.Add(this.name + ", " + this.id.ToString() + ", " + department.GetName());
						//al.Add(department.ToString());

						faculties.Add(al);
					} 
				}	
			}			
		}
		public override String ToString()
		{
			StringBuilder result = new StringBuilder();

			for(int i=0; i<faculties.Count; i++)
            {
				ArrayList temp = faculties[i] as ArrayList;
				
				result.Append("Faculty: " + temp[1] + " in " + temp[0] + " Campus\n\n");
				for(int j=2; j<temp.Count; j++)
                {
					result.Append(temp[j] + "\n");
				}
				result.Append("-------------\n");	
			}
			return result.ToString();
		}
	}
}

