using System.Threading.Tasks;

namespace Plus.EventBus
{
    public interface ILocalEventHandler<in TEvent> : IEventHandler
    {
        /// <summary>
        /// Handler handles the event by implementing this method.
        /// </summary>
        /// <param name="eventData">Event data</param>
        Task HandleEventAsync(TEvent eventData);
    }
}