<Query Kind="Program" />

/*
void Main()
{
	int i;
	i = 1;
	while (i <= 100)
	{
	  Console.WriteLine( i * 2);
	  i = i + 1;
	}
}
*/
/*
void Main()
{
	string entrada = Console.ReadLine();
	int maximo;
    maximo = int.Parse(entrada);
	int i;
	i = 1;
	while (i <= maximo)
	{
		if (i % 2 == 0) 
		{
		Console.WriteLine(i);
		}
	    i = i + 1;
	}
}
*/

void Main()
{
//	FileInfo fi = new FileInfo("F:\PIR_2014_01\local\src\Clase1\Clima en Rosario.csv");
	//no funciona el codigo de arriba porque como es un lenguaje proveniente de C la \ 
	//"barra invertida" es considerada un salto de linea
//	FileInfo fi = new FileInfo("F:\\PIR_2014_01\\local\\src\\Clase1\\Clima en Rosario.csv");
	FileInfo fi = new FileInfo(@"F:\PIR_2014_01\local\src\Clase1\Clima en Rosario.csv");
/*	FileInfo fi = new FileInfo(@"F:\PIR_2014_01\local\src
	
	
	
	\Clase1\Clima en Rosario.csv");//es valido cuando tiene verbatim (@) delante de todo
*/
    
}
// Define other methods and classes here
