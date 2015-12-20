using System; 
public class Program 
{ 
	public static void Main(string[] args)
	{ 
		Console.WriteLine("Hello World from Core CLR on Linux");
		if (args.Length > 0)
		{
			Console.WriteLine("You entered the following {0} command line argument(s):", args.Length );
			for (int i=0; i < args.Length; i++)
			{
				Console.WriteLine("{0}", args[i]);
			}
		}
	} 
}

