using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Book
    {
        Author author;
        Content content;

        //public Book(){};
        public Book(string author, string content)
        {
            this.author =  new Author(author);
            this.content = new Content(content);
        }
        public void Show()
        {
            content.Show();
            author.Show();
        }
    }
}
