using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class Stats
    {
        List<double> lstnum;
        public Stats(List<double> num)
        {
            lstnum = num;
        }
        public double Average()
        {
            if (!lstnum.Any())
                return double.NaN;

            return lstnum.Average();
        }
        public double Min()
        {
            if (!lstnum.Any())
                return double.NaN;

            return lstnum.Min();
        }
        public double Max()
        {
            if (!lstnum.Any())
                return double.NaN;

            return lstnum.Max();
        }
    }
}
