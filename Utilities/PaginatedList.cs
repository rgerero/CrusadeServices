using CrusadeServices.Models;

namespace CrusadeServices.Utilities
{
	//Another way to implement a generic pagination to be used by all models
	public class PaginatedList<T> : List<T>
	{
		public int _pageIndex { get; set; }
		public int _totalPages { get; set; }
		public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
		{
			_pageIndex = pageIndex;
			_totalPages = (int)Math.Ceiling(count / (double)pageSize);
			this.AddRange(items);
		}

		public bool HasPreviousPage => _pageIndex > 1;
		public bool HasNextPage => _pageIndex < _totalPages;

		public static PaginatedList<T> Create(List<T> source, int pageIndex, int pageSize)
		{
			var count = source.Count;
			var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
			return new PaginatedList<T>(items, count, pageIndex, pageSize);
		}
	}
}
