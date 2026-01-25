// This code is part of CoffeeSharp.



namespace java.io
{
	public class FilterOutputStream : OutputStream
	{
		protected OutputStream outstrm;
    
		public FilterOutputStream(OutputStream outstrm) 
		{
			this.outstrm = outstrm;
		}
		
		public override void write(int n)
		{
			this.outstrm.write(n);
		}
    
		public override void write(byte[] array)
		{
			this.write(array, 0, array.Length);
		}
    
		public override void write(byte[] array, int n, int n2)
		{
			if ((n | n2 | array.Length - (n2 + n) | n + n2) < 0) {
				throw new IndexOutOfBoundsException();
			}
			for (int i = 0; i < n2; ++i) {
				this.write(array[n + i]);
			}	
		}
    
		public override void flush()
		{
			this.outstrm.flush();
		}
    
		public override void close()
		{
			// The try-catch is not needed here as flush() does not throw anything
			this.flush();
			this.outstrm.close();
		}
	}
}