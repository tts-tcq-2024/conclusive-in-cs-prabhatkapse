
namespace BatteryAlert
{
    public class TypewiseAlert
    {
        private readonly IAlert Alert;
        public TypewiseAlert(IAlert _Alert)
        {
            Alert = _Alert;
        }

        public void CheckAndAlert(BatteryCharacter batteryChar, double temperatureInC)
        {
            BreachType breachType = TypewiseAlertHelpers.ClassifyTemperatureBreach(batteryChar.coolingType, temperatureInC);

            Alert.Send(breachType);
        }
    }
}
