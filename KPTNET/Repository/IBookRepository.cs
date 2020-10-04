using KPTNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPTNET.Repository
{
    /// <summary>
    /// This is the interface for Book, that will be implemented in services folder
    /// </summary>
    public interface IBookRepository
    {
        string CreateNewBook(Book book);
        string DeleteBook(int bookId);
        void UpdateBook(Book book);
        Book GetBookById(int bookId);
        List<Book> GetBooks();
    }
}
