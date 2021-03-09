using System;

namespace WebApplication2.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                if ((PageNumber > 1)) return true;
                return false;
            }
        }

        public bool HasNextPage
        {
            get
            {
                if ((PageNumber < TotalPages)) return true;
                return false;
            }
        }
    }
}