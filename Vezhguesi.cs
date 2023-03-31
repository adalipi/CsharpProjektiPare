
using Microsoft.Extensions.Logging;
using Quartz;

namespace ProjektiPare
{
    [DisallowConcurrentExecution]
    public class Vezhgues : IJob
    {
        private readonly IProgramMenaxheri _manageri;
        public Vezhgues(IProgramMenaxheri manageri)
        {
            _manageri = manageri;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await _manageri.BejPunen();
        }
    }
}
