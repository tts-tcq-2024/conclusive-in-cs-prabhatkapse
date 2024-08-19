namespace BatteryAlert
{
    public class SendToEmail : IAlert
    {
        public void Send(BreachType breachType)
        {
            var recepients = new List<string>() {"a.b@c.com"};
                
            foreach (string recipient in recepients)
            {
                if (breachType == BreachType.NORMAL)
                {
                    break;
                }
                Console.WriteLine("To: {}\n", recipient);
                Console.WriteLine($"Hi, the temperature is {breachType.ToString()}\n");
            }
        }
    }
}
