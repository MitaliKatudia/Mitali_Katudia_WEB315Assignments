using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheUnoBooks.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace TheUnoBooks.Pages_Books
{
    public class IndexModel : PageModel
    {
        private readonly TheUnoBooks.Data.TheUnoBooksContext _context;
        public IndexModel(TheUnoBooks.Data.TheUnoBooksContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
