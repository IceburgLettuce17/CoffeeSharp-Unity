// This code is part of CoffeeSharp.



namespace java.lang
{
	// TODO: move PrintStream to separate class
	public class PrintStream
	{
		void println(string text) => Debug.Log(text + "/n");
	}
	
	public sealed class System
	{
		public static sealed PrintStream out_;
		public static sealed PrintStream err;
	}
}