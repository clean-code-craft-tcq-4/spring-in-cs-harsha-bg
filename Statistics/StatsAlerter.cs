using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsAlerter
    {
        float maxThreshold;
        IAlerter[] alerters;
        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }
        public void checkAndAlert(List<double> num)
        {
            if (num.Max() > maxThreshold)
            {
                EmailAlert emailAlert = (EmailAlert)alerters[0];
                LEDAlert lEDAlert = (LEDAlert)alerters[1];
                emailAlert.emailSent = true;
                lEDAlert.ledGlows = true;
            }
        }
    }
}
