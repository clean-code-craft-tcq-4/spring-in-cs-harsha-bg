using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }
       
        public Stats CalculateStatistics(List<double> numbers) {
            Stats st =  new Stats(numbers);
            average = st.Average();
            max = st.Max();
            min = st.Min();
            return st;
        }
    }
}
