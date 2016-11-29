using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinkedListKata
{
    public class SimpleLinkedList<T> :IEnumerable<T>
    {
        public SimpleLinkedList(T value)
        {
            Value = value;
        }

        public SimpleLinkedList(IEnumerable<T> values) : this(values.First())
        {
            var current = this;
            current = values.Skip(1)
                .Aggregate(current, (current1, value) 
                => current1.Add(value).Next);
        }

        public T Value { get; set; }

        public SimpleLinkedList<T> Next { get;  private set; }

        public SimpleLinkedList<T> Add(T value)
        {
            Next = new SimpleLinkedList<T>(value);
            return this;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this;

            do
            {
                yield return current.Value;
                current = current.Next;
            } while (current != null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
