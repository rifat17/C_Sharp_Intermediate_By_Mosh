using System;
namespace C_Sharp_Intermediate_By_Mosh.Interfaces_Polymorphism036
{

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}
