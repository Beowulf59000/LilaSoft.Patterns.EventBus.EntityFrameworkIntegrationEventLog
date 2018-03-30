namespace LilaSoft.Patterns.EventBus.EntityFrameworkIntegrationEventLog.Services
{
    using System.Threading.Tasks;
    using System.Data.Common;
    using LilaSoft.Patterns.EventBus.EventBus.Events;

    public interface IIntegrationEventLogService
    {
        Task SaveEventAsync(IntegrationEvent @event, DbTransaction transaction);
        Task MarkEventAsPublishedAsync(IntegrationEvent @event);
    }
}
