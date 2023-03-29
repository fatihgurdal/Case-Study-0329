using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        ICollection<Member> Members { get; set; }
        ICollection<Book> Books { get; set; }
        ICollection<BookTransaction> BookTransactions { get; set; }
    }
}
