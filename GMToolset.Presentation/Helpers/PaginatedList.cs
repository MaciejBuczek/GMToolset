namespace GMToolset.Presentation.Helpers
{
    public class PaginatedList<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public List<T> Items { get; set; }
        public bool HasNextPage
        {
            get { return PageIndex < TotalPages; }
        }

        public bool HasPreviousPage
        {
            get { return PageIndex > 1; }
        }

        public PaginatedList()
        {

        }

        public PaginatedList(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var skip = (PageIndex - 1) * PageSize;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            Items = source.Skip(skip).Take(pageSize).ToList();
        }

        public PaginatedList(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            var skip = (PageIndex - 1) * PageSize;
            PageIndex = pageIndex;
            PageSize = pageSize;
            var enumerable = source.ToList();
            TotalCount = enumerable.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            Items = enumerable.Skip(skip).Take(pageSize).ToList();
        }
    }
}
