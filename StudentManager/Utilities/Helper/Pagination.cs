namespace StudentManager.Utilities.Helper
{
    public class Pagination<T> where T : class
    {
        
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public string Search { get; set; } = string.Empty;
        

        public IReadOnlyList<T> Data { get; set; }
        public Pagination(int pageIndex, string search, int pageSize, int count, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
            Search = search;
            
        }
    }
}
