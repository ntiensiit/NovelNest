namespace NovelNest.Core.Models.QueryModels.Book
{
    using NovelNest.Core.Enums;
    using System.ComponentModel.DataAnnotations;

    public class AllBooksQueryModel
    {
        public int BooksPerPage { get; } = 8;

        [Display(Name = "Search")]
        public string SearchTerm { get; set; } = null!;

        [Display(Name = "Sorting")]
        public BookSorting Sorting { get; set; }

        public int TotalBooksCount { get; set; }
        public int CurrentPage { get; set; } = 1;

        [Display(Name = "Genre")]
        public string Genre { get; set; } = null!;
        public IEnumerable<string> Genres { get; set; } = null!;

        [Display(Name = "Cover")]
        public string CoverType { get; set; } = null!;
        public IEnumerable<string> CoverTypes { get; set; } = null!;

        public int BookStoreId { get; set; } = -1;

        public IEnumerable<BookServiceModel> Books { get; set; } = new HashSet<BookServiceModel>();
    }
}