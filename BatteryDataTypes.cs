
namespace BatteryAlert
{
    public enum BreachType
    {
        NORMAL,
        TOO_LOW,
        TOO_HIGH
    };
    public enum CoolingType
    {
        PASSIVE_COOLING,
        HI_ACTIVE_COOLING,
        MED_ACTIVE_COOLING
    };

    public enum AlertTarget
    {
        TO_CONTROLLER,
        TO_EMAIL
    };

    public struct BatteryCharacter
    {
        public CoolingType coolingType;
        public string brand;
    }
}
