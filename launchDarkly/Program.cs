using System;
using LaunchDarkly.Client;

namespace launchDarkly
{
    class Program
    {
        static void Main(string[] args)
        {
            var ldConfig = LaunchDarkly.Client.Configuration.Default("sdk-219b665b-50fd-4c57-809f-d5e9c94fcd9a");

            var client = new LdClient(ldConfig);
            var user = User.Builder("gaziz@emersonecologics.com")
              .FirstName("Gohar")
              .LastName("Aziz")
              .Custom("groups", "beta_testers")
              .Build();
            
            var value = client.BoolVariation("search-bug-fix", user, false);

            if (value)
                Console.WriteLine("Showing feature for user " + user.Key);
            else
                Console.WriteLine("Not showing feature for user " + user.Key);
            client.Flush();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
