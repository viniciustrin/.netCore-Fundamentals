using Microsoft.Extensions.Configuration;

namespace projetoteste
{
    public interface IGreeter
    {
        string GetMessage();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _config;

        public Greeter(IConfiguration config)
        {
            _config = config;        }
        public string GetMessage()
        {
            return _config["Greeting"];
        }
    }
}