using BatteryAlert;

internal static class TypewiseAlertHelpers
{
    private static readonly Dictionary<CoolingType, (int lowerLimit, int upperLimit)> CoolingLimits = new Dictionary<CoolingType, (int lowerLimit, int upperLimit)>
    {
        { CoolingType.PASSIVE_COOLING, (0, 35) },
        { CoolingType.HI_ACTIVE_COOLING, (0, 45) },
        { CoolingType.MED_ACTIVE_COOLING, (0, 40) }
    };

    public static BreachType ClassifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
    {
        var limits = CoolingLimits[coolingType];
        return InferBreach(temperatureInC, limits.lowerLimit, limits.upperLimit);
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
