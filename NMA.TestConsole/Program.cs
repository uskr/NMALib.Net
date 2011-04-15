// By Casey Watson
// http://www.caseywatson.com/
// Refactory and Modifications By Adriano Maia
// http://nma.usk.bz

namespace NMALib.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Before posting a notification, 
            // check out the [app.config] file to configure the Prowl client.

            // Create a notification.
            var testNotification =
                new NMANotification
                {
                    Description = "This is a test notification.",
                    Event = "Testing...",
                    Priority = NMANotificationPriority.Normal
                };

            // Create the Prowl client.
            // By default, the Prowl client will attempt to load configuration
            // from the configuration file (app.config).  You can use an overloaded constructor
            // to configure the client directly and bypass the configuration file.
            var testClient = new NMAClient();

            // Post the notification.
            testClient.PostNotification(testNotification);
        }
    }
}
