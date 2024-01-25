using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
        internal class Library_Management_SystemContext
    {

        public class LibraryManagementSystemContext : DbContext
        {
            public LibraryManagementSystemContext() : base()
            { }

            public DbSet<Library.Models.Book> Books { get; set; }

            public DbSet<Library.Models.Librarian> Librarians { get; set; }

            public DbSet<Library.Models.Report> Reports { get; set; }

            public DbSet<Library.Models.Transaction> Transactions { get; set; }

            public DbSet<Library.Models.Students> Students { get; set; }

            public DbSet<Library.Models.Borrowing> Borrowings { get; set; }
        }
    }
}