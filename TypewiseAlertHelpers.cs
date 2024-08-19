using BatteryAlert;

internal static class TypewiseAlertHelpers
{
    public static BreachType ClassifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
    {
        int lowerLimit = 0;
        int upperLimit = 0;
        switch (coolingType)
        {
            case CoolingType.PASSIVE_COOLING:
                lowerLimit = 0;
                upperLimit = 35;
                break;
            case CoolingType.HI_ACTIVE_COOLING:
                lowerLimit = 0;
                upperLimit = 45;
                break;
            case CoolingType.MED_ACTIVE_COOLING:
                lowerLimit = 0;
                upperLimit = 40;
                break;
        }
        return InferBreach(temperatureInC, lowerLimit, upperLimit);
    }

    public static BreachType InferBreach(double value, double lowerLimit, double upperLimit)
    {
        if (value < lowerLimit)
        {
            return BreachType.TOO_LOW;
        }
        if (value > upperLimit)
        {
            return BreachType.TOO_HIGH;
        }
        return BreachType.NORMAL;
    }
}
