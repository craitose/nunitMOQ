using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathOperations
{
	public class Maths
	{
		public int sum(int x, int y)
		{
			return x + y;
		}

		public int sub(int x, int y)
		{
			return x - y;
		}

		public int mul(int x, int y)
		{
			return x * y;
		}

		public int div(int x, int y)
		{
			return x / y;
		}

		public virtual bool checkDigitsOnly() // make values virtual for mock to override
		{
			return false;
		}
	}

}
