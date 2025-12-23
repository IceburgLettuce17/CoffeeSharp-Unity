
namespace java.io
{
	public abstract class OutputStream : Closeable, Flushable
	{
		public abstract void write(int p0);
		
		public void write(byte[] array) => write(array, 0, array.Length);
		
		public void write(byte[] array, int n, int n2) throws IOException {
			if (array == null) {
				throw new NullPointerException();
			}
			if (n < 0 || n > array.length || n2 < 0 || n + n2 > array.length || n + n2 < 0) {
				throw new IndexOutOfBoundsException();
			}
			if (n2 == 0) {
				return;
			}
			for (int i = 0; i < n2; i++) 
			{
				this.write(array[n + i]);
			}
		}
		
		public void flush(){}
		
		public void close(){}
	}
}
