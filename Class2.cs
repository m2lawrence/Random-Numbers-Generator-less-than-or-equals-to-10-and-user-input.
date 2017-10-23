//external class.
using System;

namespace Test1
{
	public class Class2
	{
		public static int answer = 0;
		//pass this class the number and return it.
		public int checkNumber(int number)
		{		
		//return the int back to the main class to use.
		if ((number >=1) && (number <=10)) {
	         answer = number;
		     }
		return answer;
		//answer gets used for the random method.
		}
	}
} 