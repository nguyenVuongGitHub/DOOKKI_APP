using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Helpers
{
    internal class PageChanging
    {
        //private readonly DookkiContext _context;

        //private int currentPageIndex = 1;
        //private int totalPages;
        //public PageChanging(DookkiContext context)
        //{
        //    _context = context;
        //}
        //public void UpdateTotalPages(int pageSize)
        //{
        //    int totalRecords = _context.Set<ModelT>().Count();
        //    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
        //}
        //public void NextPage()
        //{
        //    if (currentPageIndex + 1 < totalPages)
        //        currentPageIndex++;
        //    else
        //        currentPageIndex = 1;
        //}
        //public void PreviousPage()
        //{
        //    if (currentPageIndex > 1 && currentPageIndex <= totalPages)
        //        currentPageIndex--;
        //    else
        //        currentPageIndex = totalPages;
        //}
        //public int CurrentPageIndex => currentPageIndex;
        //public int TotalPages => totalPages;
    }
}
