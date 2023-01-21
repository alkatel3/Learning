using System.Collections.Specialized;

namespace observableCollection
{
    internal class NotifyCollectionChangedEvent
    {
        public NotifyCollectionChangedAction Action { get; internal set; }
        public object NewItems { get; internal set; }
    }
}