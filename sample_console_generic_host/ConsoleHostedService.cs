


using Microsoft.Extensions.Options;

namespace sample_console_generic_host
{
    public class ConsoleHostedService(IHostApplicationLifetime _AppLifetime) : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _AppLifetime.ApplicationStarted.Register(OnStarted);
            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }

        [STAThread]
        private void OnStarted()
        {
            try
            {
                StartedAsync().GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);

                Environment.ExitCode = (int) ExitCode.Exception;
            }
            finally
            {
                _AppLifetime.StopApplication();
            }

            async Task StartedAsync()
            {
                var args = Environment.GetCommandLineArgs();
                await Task.CompletedTask;
            }
        }
    }
}
