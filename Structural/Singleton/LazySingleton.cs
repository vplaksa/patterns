using System;

namespace Creational.Singleton
{
    //signleton itself
    public class Lazy3rdPartySystemClient
    {
        public static IClient Instance => _lazyClient.Value;

        private static readonly Lazy<IClient> _lazyClient =
            new Lazy<IClient>(CreateClient);

        private static IClient CreateClient()
        {
            //var clientSettings = new JsonClientSettings("MyExternalApiSettings");
            //var client = new MySale.Warehouse.Manufacture.V1.ManufactureClient(clientSettings.Url,
            //    clientSettings.Key);

            return null;
        }
    }

    //Client to an external system. could be downloaded from NuGet and added manually 
    public interface IClient
    {
        int GetRandom();
    }

    public class MyClient : IClient
    {
        public int GetRandom()
        {
            return 4; //believe, its random. trust me i'm an engineer
        }
    }

}
