using System;

namespace DataGridWinApp1
{
	public class DataClass
	{
		public DataClass(int seed)
		{
			IntProperty = seed;
			StringProperty = "Text " + seed;
			DateProperty = DateTime.Now.AddDays(-seed);
		}

		public DataClass()
		{
		}

		public int IntProperty
		{
			get;
			set;
		}

		public string StringProperty
		{
			get;
			set;
		}

		public DateTime DateProperty
		{
			get;
			set;
		}
	}
}
