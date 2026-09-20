using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04CSharpBasics
{
    internal class Book
    {
        private string password = "secret";

        internal int copiesInStock = 5;

        public string Title;

        public Genre Genre { get; set; }



    }
}
