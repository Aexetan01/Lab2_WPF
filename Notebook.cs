using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ivan_WPF
{
    public class Notebook
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int length;

		public int Length
		{
			get { return length; }
			set { length = value; }
		}

		private double k;

		public double K
		{
			get { return k; }
			set { k = value; }
		}


		public Notebook()
		{
			Name = string.Empty;
			Length = 0;
			K = 0;
		}

		public Notebook(string name, int length, double k)
		{
			Name = name;
			Length = length;
			K = k;
		}

		public virtual double GetPrince()
		{
			return 15d * k;
		}
	}
}
