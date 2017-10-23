using System;
using Test1;

namespace Test1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//declare a string variable to store input.
			string stringNumberEntered;
			
			//ask the user to enter a number between 1-10.
			Console.Write("Enter a number between 1-10: ");
			
			//store the entered number.
			stringNumberEntered = Console.ReadLine();
			
			//declare the int varable that is used in the other class later.
			int number = 0;
			//convert the string to int data type. 
			number = Convert.ToInt32(stringNumberEntered);
			
			//----------------------------------------------------------------------
			//build an object from the other class.
			Test1.Class2 Object1 = new Class2();
			
			//call the number in the other object by using the class method checkNumber and passing it the number, and convert from int to string.
			string input = Convert.ToString(Object1.checkNumber(number));
      		
      		//set the random number ctr.
  	        uint NumberEntered = 0;
      		//build the random object.
 	        Random rnd = new Random();
			//convert string to UInt32.
  	        if (! UInt32.TryParse(input, out NumberEntered))
  	        NumberEntered = 0; 	        
  	        
				//store random generated numbers in an array of 10.
				int[] Array = new int[11];
				
				//create numbers and store in an array.
   	        	for (uint ctr = 1; ctr <= NumberEntered; ctr++)
   	        	{
   	        	  	Array[ctr] = rnd.Next(1,11);   	        		   	        		
   	    		}
   	        	
   	        	//write numbers. 	        	
   	        	for (int i=0; i< Array.Length; i++) 
   	        	{
   	        		if (Array[i] >=1) 
   	        		{
   	        		Console.Write(Array[i] + ",");
   	        		}
   	        	}   	        
			//pause.
			Console.Read();
		}
	}
}
