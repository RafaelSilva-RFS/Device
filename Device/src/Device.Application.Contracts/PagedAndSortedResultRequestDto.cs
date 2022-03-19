namespace Device.Application.Contracts
{
    public class PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public int PageNumber { get; set; } = 1;
        public int MaxResultCount { get; set; } = 5;

        public string Sorting { get; set; } = "CreationTime";

        public int SkipCount { 
            get => (PageNumber - 1) * MaxResultCount; 
            set => SkipCount = value; 
        }
    }
}
