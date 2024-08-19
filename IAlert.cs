namespace BatteryAlert
{
    public interface IAlert
    {
        public void Send(BreachType breachType);
    }
}
