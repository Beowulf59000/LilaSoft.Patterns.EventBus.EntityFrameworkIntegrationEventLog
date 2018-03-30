namespace LilaSoft.Patterns.EventBus.EntityFrameworkIntegrationEventLog.Services
{
    using System.Threading.Tasks;
    using System.Data.Common;

    public interface IIntegrationEventLogService
    {
        Task SaveEventAsync(IntegrationEvent @event, DbTransaction transaction);
        Task MarkEventAsPublishedAsync(IntegrationEvent @event);
    }
}
