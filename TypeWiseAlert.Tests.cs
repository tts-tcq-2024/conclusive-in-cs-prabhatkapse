using System;
using Xunit;
using BatteryAlert;

namespace BatteryAlert
{
    public class TypeWiseAlertTests
    {
        //1. Correct BreachType is coming or not?
        //2. Correct Cooling type is sending correct limits or not?
        //3. Correct mail or controller msg is being send or not?
        TypewiseAlert typewiseAlert;
        double temperatureInC = 0;

        [Fact]
        public void BreachTypeCheck()
        {
            var mopBreachType = new MopBreachType();
            typewiseAlert = new TypewiseAlert(mopBreachType);

            BatteryCharacter batteryChar = new BatteryCharacter();

            batteryChar.coolingType = CoolingType.PASSIVE_COOLING;
            temperatureInC = 36.2f;
            typewiseAlert.CheckAndAlert(batteryChar, temperatureInC);
            Assert.Equal(mopBreachType._breachType, BreachType.TOO_HIGH);

            temperatureInC = -10.0f;
            typewiseAlert.CheckAndAlert(batteryChar, temperatureInC);
            Assert.Equal(mopBreachType._breachType, BreachType.TOO_LOW);


            batteryChar.coolingType = CoolingType.MED_ACTIVE_COOLING;
            temperatureInC = 40.2f;
            typewiseAlert.CheckAndAlert(batteryChar, temperatureInC);
            Assert.Equal(mopBreachType._breachType, BreachType.TOO_HIGH);

            batteryChar.coolingType = CoolingType.HI_ACTIVE_COOLING;
            temperatureInC = 45.2f;
            typewiseAlert.CheckAndAlert(batteryChar, temperatureInC);
            Assert.Equal(mopBreachType._breachType, BreachType.TOO_HIGH);
        }
    }
}

