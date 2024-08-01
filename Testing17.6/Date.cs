using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._6
{
	class Date
	{
		//Attributes
		private int DateDay;
		private int DateMonth;
		private int DateYear;

		//Properties
		public Date(int DateDay, int DateMonth, int DateYear)
		{
			this.DateDay = DateDay;
			this.DateMonth = DateMonth;
			this.DateYear = DateYear;
		}
		

		//Constructors
		public bool KiemTraNamNhuan()
		{
			return ((this.DateYear % 4 == 0 && this.DateYear % 100 != 0) || this.DateYear % 400 == 0);
		}
		public int getDateDay()
		{
			switch (this.DateMonth)
			{
				case 1: case 3: case 5: case 7: case 8: case 10: case 12:
					{
						if (DateDay < 0 || DateDay > 31)
                        {
                            Console.WriteLine("You exist in a non-exist space.");
							break;
                        }
						else
                        {
							return this.DateDay;
                        }
					}
				case 2:
					{
						if (KiemTraNamNhuan())
						{
							if (DateDay < 0 || DateDay > 29)
							{
								Console.WriteLine("You exist in a non-exist space.");
								break;
							}
							else
							{
								return DateDay;
							}
						}
						else 
						{	if (DateDay < 0 || DateDay > 28)
							{
								Console.WriteLine("You exist in a non-exist space.");
								break;
							}
							else
							{
								return DateDay;
							}
						}
					}
				case 4: case 6: case 9: case 11:
					if (DateDay < 0 || DateDay > 30)
					{
						Console.WriteLine("You exist in a non-exist space.");
						break;
					}
					else
					{
						return DateDay;
					}
			}
			return DateDay;
		}

		public void setDateDay(int DateDay)
		{
			this.DateDay = DateDay;
		}

		public int getDateMonth()
		{
			switch(this.DateMonth)
            {
				case 1: this.DateMonth = 1; break;
				case 2: this.DateMonth = 2; break;
				case 3: this.DateMonth = 3; break;
				case 4: this.DateMonth = 4; break;
				case 5: this.DateMonth = 5; break;
				case 6: this.DateMonth = 6; break;
				case 7: this.DateMonth = 7; break;
				case 8: this.DateMonth = 8; break;
				case 9: this.DateMonth = 9; break;
				case 10: this.DateMonth = 10; break;
				case 11: this.DateMonth = 11; break;
				case 12: this.DateMonth = 12; break;
				case 13:
					if (this.DateMonth < 0 || this.DateMonth > 12)
					{ Console.WriteLine("No existance of this month."); } 
					break;
			}
			return this.DateMonth;
		}

		public void setDateMonth(int DateMonth)
		{
			this.DateMonth = DateMonth;
		}

		public int getDateYear()
		{
			return DateYear;
		}

		public void setDateYear(int DateYear)
		{
			if (this.DateYear < 0)
			{
				Console.WriteLine("Are you from the no-existed space?");
			}
			else if (this.DateYear > DateTime.Now.Year)
			{
				Console.WriteLine("So you're from the future!");
			}
			else
			{
				this.DateYear = DateYear;
			}			
		}

		//Methods
		public void setDate(int DateDay, int DateMonth, int DateYear)
		{
			this.DateDay = DateDay;
			this.DateMonth = DateMonth;
			this.DateYear = DateYear;
		}
		public override string ToString()
        {
			return "Date: " + getDateDay() + "/" + getDateMonth() + "/" + getDateYear();
        }

    }
}

