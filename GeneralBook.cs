using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ivan_WPF
{
    public class GeneralBook : Notebook
    {
        private string coverMaterial;

        public string CoverMaterial
        {
            get { return coverMaterial; }
            set { coverMaterial = value; }
        }

        public GeneralBook() : base()
        {
            CoverMaterial = string.Empty;
        }

        public GeneralBook(string name, int length, double k, string coverMaterial) : base(name, length, k)
        {
            CoverMaterial = coverMaterial;
        }

        public override double GetPrince()
        {
            return base.GetPrince() + 50;
        }
    }
}
