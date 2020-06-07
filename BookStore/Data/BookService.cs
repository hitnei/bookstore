using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    
    public class BookService
    {
        private DatabaseContext appDataContext;

        public BookService(DatabaseContext appDataContext)
        {
            this.appDataContext = appDataContext;
        }

        public ICollection<Book> ListAllBooks()
        {
            return appDataContext.Book.ToList();
        }
    }
}
