using System; 
public class Program 
{ 
	public static void Main(string[] args)
	{ 
		Console.WriteLine("Hello World from beautiful Core CLR!");
		if (args.Length > 0)
		{
			Console.WriteLine("You entered the following {0} command line arguments:", args.Length );
			for (int i=0; i < args.Length; i++)
			{
				Console.WriteLine("{0}", args[i]);
			}
		}
	} 
}

