using System;
using System.Text;

namespace FacultyNs
{
	public class Faculty
	{
		private String name; //Predefined Name of the Faculty
		private String campus;
		private String university; //The University to which faculty belongs to
		private String description;

		public Faculty(String name, String campus, String university, String description)
		{
			this.name = name;
			this.campus = campus;
			this.university = university;
			this.description = description;
		}

		public String GetName()
        {
			return this.name;
        }

		public String GetCampus()
        {
			return this.campus;
        }

		public String GetUniversity()
        {
			return this.university;
        }
		
		public String GetDescription()
        {
			return this.description;
        }
		
		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			result.Append("- Faculty Name: " + this.name + "\n");
			result.Append("- Campus: " + this.campus + "\n");
			result.Append("- University: " + this.university + "\n");
			result.Append("- Description: " + this.description + "\n");
		
			return result.ToString();
		}
	}
}

