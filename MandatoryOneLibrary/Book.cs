using System;

namespace MandatoryOneLibrary
{
    /// <summary>
    /// Describes a book.
    /// </summary>
    class Book
    {
        private string _isbn13;


        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The author of the book. First name and last name.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Total number of pages in the book.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// International Standard Book Number. Unique identifier for a book. Must be 13 digits.
        /// </summary>
        public string ISBN13
        {
            get { return _isbn13; }
            set
            {
                var temp = value;
                temp = temp.Replace("-", "");

                if (!(temp.Length == 13))
                {
                    throw new ArgumentException("Invalid ISBN13", value);
                }

                _isbn13 = temp;
            }
        }
    }
}
