namespace Device.Application.Contracts
{
    public class PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public int PageNumber { get; set; }
        public int MaxResultCount { get; set; }

        public string Sorting { get; set; }

        public int SkipCount { 
            get => (PageNumber - 1) * MaxResultCount; 
            set => SkipCount = value; 
        }
    }
}
