using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace Infrastructure.Persistence
{
    public class CaseDbContext : DbContext, IApplicationDbContext
    {
        public CaseDbContext(DbContextOptions<CaseDbContext> options) : base(options)
        {
        }
        public ICollection<Member> Members { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<BookTransaction> BookTransactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = Assembly.GetAssembly(typeof(DbContext));
            modelBuilder.ApplyConfigurationsFromAssembly(assembly,
                t => t.GetInterfaces().Any(i =>
                    i.IsGenericType &&
                    i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>) &&
                    typeof(BaseEntity<>).IsAssignableFrom(i.GenericTypeArguments[0]))
                );

        }
    }
}
