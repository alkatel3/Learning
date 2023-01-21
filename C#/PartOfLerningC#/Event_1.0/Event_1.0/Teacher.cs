using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_1._0
{
    class Teacher
    {
        SortedList<int, EventHandler<ExamEventArgs>> _sortedEvents =
            new();
        Random _rand = new();
        public event EventHandler<ExamEventArgs> examEvent
        {
            add
            {
                for(int key; ;)
                {
                    key = _rand.Next();
                    if (!_sortedEvents.ContainsKey(key))
                    {
                        _sortedEvents.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
            }
        }

        public void Exam(ExamEventArgs task)
        {
            foreach (int item in _sortedEvents.Keys)
            {
                _sortedEvents[item]?.Invoke(this, task);
            }
        }
    }
}
