using System.Collections.Generic;

namespace Domain.Dto
{
    public class Data<T>
    {
        public Data(IEnumerable<T> results, long count)
        {
            Results = results;
            Count = count;
        }
        public IEnumerable<T> Results { get; private set; }
        public long? Count { get; private set; }
    }
}