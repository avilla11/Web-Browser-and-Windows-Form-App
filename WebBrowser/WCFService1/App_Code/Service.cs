using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public int c2f(int c)
	{
		int result = c * 9 / 5 + 32; //calulating result
		return result;
	}
	public int f2c(int f)
	{
		int result = (f - 32) * 5 / 9; //calculating result
		return result;
	}

	public string hi()
	{
		string s = "no";
		return string.Format("{0}", s);
	}

	public string sort(string s)
	{
		//string s = "1,10,7,6,3";
		string[] stringArray = s.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); //splitting and placing the string in array
		int length = stringArray.Length; //calculating length for new intarray for sorting
		int[] intArray = new int[length]; //creating new array
		for (int i = 0; i < length; i++) //looping whole length with try catch for non number entry
		{
			try
			{
				intArray[i] = Convert.ToInt32(stringArray[i]);
			}
			catch (Exception)
			{
				Console.WriteLine("Enter only a comma separated list of numbers");
			}
		}
		Array.Sort(intArray); //sorting the integer array after conversion of input
		string[] result = Array.ConvertAll(intArray, x => x.ToString()); //placing sorted int array into string array
		string string1 = string.Join(",", result);
		string1 = string1.Replace("\"", "");
		//var result2 = string.Join(",", result); //placing string array into new var so it can print all values not just first
		//result2 = result2.Replace("\"", "");
		return string.Format("{0}", string1); //returning
											  //var result = string.Join(",", x.Select(n => "\"" + n + "\"")); "1","2","3"
	}
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}