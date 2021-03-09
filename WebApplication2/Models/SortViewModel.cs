using WebApplication2.coursework;

namespace WebApplication2.Models
{
    public class SortViewModel
    {
        public Product.SortState NameSort { get; set; }
        public Product.SortState PriceSort { get; set; }
        public Product.SortState Current { get; set; }
        //public bool Up { get; set; }

        public SortViewModel(Product.SortState sortOrder)
        {
            NameSort = sortOrder == Product.SortState.NameAsc ? Product.SortState.NameDesc : Product.SortState.NameAsc;
            PriceSort = sortOrder == Product.SortState.PriceAsc ? Product.SortState.PriceDesc : Product.SortState.PriceAsc;
            Current = sortOrder;
        }

        //public SortViewModel(Product.SortState sortOrder)
        //{
        //    // значения по умолчанию
        //    NameSort = Product.SortState.NameAsc;
        //    PriceSort = Product.SortState.PriceAsc;
        //    Up = true;

        //    if (sortOrder == Product.SortState.PriceDesc || sortOrder == Product.SortState.NameDesc)
        //    {
        //        Up = false;
        //    }

        //    switch (sortOrder)
        //    {
        //        case Product.SortState.NameDesc:
        //            Current = NameSort = Product.SortState.NameAsc;
        //            break;
        //        case Product.SortState.PriceAsc:
        //            Current = PriceSort = Product.SortState.PriceDesc;
        //            break;
        //        case Product.SortState.PriceDesc:
        //            Current = PriceSort = Product.SortState.PriceAsc;
        //            break;
        //        default:
        //            Current = NameSort = Product.SortState.NameDesc;
        //            break;
        //    }
        //}
    }
}