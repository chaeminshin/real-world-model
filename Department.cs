using System;
using System.Text;

using FacultyNs;

namespace DepartmentNs
{
	public class Department
	{
		private int number = 0;
		private String name;
		private Faculty faculty;

		public Department()
        {

        }
		public Department(String name, Faculty faculty)
		{
			this.name = name;
			this.faculty = faculty;
		}

		public String GetName()
        {
			return this.name;
        }
		public Faculty GetFaculty()
        {
			return this.faculty;
        }

		public int NextNumber()
        {
			number++;
			return number;
        }

		public String GetTotalNumberInfo()
        {
			StringBuilder result = new StringBuilder();
			result.Append("* Department Name: " + this.name + "\n");
			result.Append("- Total Number of Students in the Department: " + number + "\n\n");
			return result.ToString(); 
        }

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			
			result.Append("* Department Name: " + this.name + "\n");
			result.Append("- Total Number of Students in the Department: " + number + "\n");
			result.Append("- Faculty Name: " + this.faculty.GetName() + "\n");
			
			return result.ToString();
		}

		public override bool Equals(object obj)
		{
			Department otherDepartment = obj as Department;
			if (otherDepartment == null)
			{
				return false;
			}
			bool equals = object.Equals(this.faculty, otherDepartment.faculty);
			
			return equals;
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((this.name == null) ? 0 : this.name.GetHashCode());
			result = prime * result + ((this.faculty == null) ? 0 : this.faculty.GetHashCode());
			return result;
		}
	}
}