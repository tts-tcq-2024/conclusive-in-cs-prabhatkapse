namespace BatteryAlert
{
    public class MopBreachType : IAlert
    {
        public BreachType _breachType;

        public MopBreachType()
        {
            _breachType = new BreachType();
        }

        public void Send(BreachType breachType)
        {
            _breachType = breachType;
        }
    }
}
