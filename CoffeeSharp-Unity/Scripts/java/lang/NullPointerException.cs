// This code is part of CoffeeSharp.



using System;
using System.Runtime.Serialization;

namespace java.lang
{
	[Serializable]
	public class NullPointerException : Exception
	{
		public NullPointerException() {}
		
		public NullPointerException(string s) : base(s){}
	}
}