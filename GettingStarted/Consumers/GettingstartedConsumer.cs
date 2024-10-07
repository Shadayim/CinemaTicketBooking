namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class gettingstartedConsumer :
        IConsumer<gettingstarted>
    {
        public Task Consume(ConsumeContext<gettingstarted> context)
        {
            return Task.CompletedTask;
        }
    }
}