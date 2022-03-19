using System.Collections.Generic;

namespace Device.Application.Contracts
{
    public class PagedResultDto<T>
    {
        public long TotalCount { get; set; }

        private IReadOnlyList<T> _items;
        public IReadOnlyList<T> Items
        {
            get { return _items ?? (_items = new List<T>()); }
            set { _items = value; }
        }

        public PagedResultDto(long totalCount, IReadOnlyList<T> items)
        {
            TotalCount = totalCount;
            Items = items;
        }
    }
}
