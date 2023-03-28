using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ProjektiPare
{
    public class TestLogim
    {
        private readonly ILogger<TestLogim> _logger;
        private readonly IConfiguration _config;

        public TestLogim(ILogger<TestLogim> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void Shenim() 
        {
            var test = _config["Folderi"];
            _logger.LogInformation($"shenuam dicka ne log: {test}");
            _logger.LogError("gabim gabim..");
        }
    }
}
