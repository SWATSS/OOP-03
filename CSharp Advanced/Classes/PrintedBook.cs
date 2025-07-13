using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Classes
{
    internal class PrintedBook : Book
    {
        int PageCount { get; set; }
        public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;
        }
        public override string ToString()
        {
            base.ToString();
            return $"PageCount: {PageCount}";
        }

    }
}
