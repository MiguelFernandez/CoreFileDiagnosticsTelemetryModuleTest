using System.Diagnostics.Tracing;

namespace testingAICore
{
    internal interface IEventListener
    {
        /// <summary>
        /// Sends diagnostics data to the appropriate output.
        /// </summary>
        /// <param name="eventData">Information about trace event.</param>
        void OnEventWritten(EventWrittenEventArgs eventData);
    }
}
