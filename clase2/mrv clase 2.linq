<Query Kind="Program" />

void Main()
{
	//string s = "Hola Mundo!!";
	string s = "123";
	//float ff = s; no me permite
	float ff = float.Parse(s);
	
	Console.WriteLine(ff);
	/*
	float ff = 123.4f;
	
	DateTime dat = DateTime.Now;
	
	DateTime1 d1 = null;
	d1.IsLapYear();
	DateTime1.IsLapYear(2000);
	*/
}

// Define other methods and classes here


public class DateTime1
{
  public bool IsLapYear()
  {
    return false;
  }
  
  public static bool IsLapYear(int año)
  {
    return false;
  }
}
