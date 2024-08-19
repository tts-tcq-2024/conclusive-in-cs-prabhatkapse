namespace BatteryAlert
{
    public class SendToController : IAlert
    {
        public void Send(BreachType breachType)
        {
            const ushort header = 0xfeed;
            Console.WriteLine("{} : {}\n", header, breachType);
        }
    }
}
