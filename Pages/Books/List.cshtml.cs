using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Net.Core.FirstProject.Core;
using Net.Core.FirstProject.Data;

namespace Net.Core.FirstProject.App.Pages.Books
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IBookData bookData;

        public IEnumerable<Book> Books;

        public ListModel(IConfiguration config, IBookData bookData)
        {
            this.config = config;
            this.bookData = bookData;
        }

        public void OnGet()
        {
            Books = this.bookData.GetAll();
        }
    }
}