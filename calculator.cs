class Calculator
{
	static void Main (string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriteLine("\nTekan sembarangan key untuk keluar");
		Console.ReadKey();
	}
	ststic int Prnambahan(int a, int b)
	{
		return a + b;
	}
	ststic int Pengurangan(int a, int b)
	{
		return a - b;
	}
	
}