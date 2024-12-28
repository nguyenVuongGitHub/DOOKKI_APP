using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Helpers
{
    internal class PageChanging<ModelT> where ModelT : class
    {
        // danh sách mà class này thực hiện tới
        private List<ModelT> _listOfModel;

        private int currentPageIndex = 1;
        private int totalPages;
        public PageChanging(List<ModelT> listOfModel)
        {
            _listOfModel = listOfModel;
        }

        /// <summary>
        /// // khi danh sách hiển thị có thay đổi, gọi hàm này
        /// </summary>
        /// <param name="listOfNewModel"> danh sách mới </param>
        public void UpdateListOfModel(List<ModelT> listOfNewModel)
        {
            _listOfModel.Clear();
            _listOfModel = listOfNewModel;
        }
        /// <summary>
        /// Tính tổng trang hiện có nếu chia theo pagesize
        /// </summary>
        /// <param name="pageSize"> số dòng hiển thị trên gridview </param>
        public void UpdateTotalPages(int pageSize)
        {
            int totalRecords = _listOfModel.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
        }
        public void NextPage()
        {
            if (currentPageIndex + 1 <= totalPages)
                currentPageIndex++;
            else
                currentPageIndex = 1;
        }
        public void PreviousPage()
        {
            if (currentPageIndex > 1 && currentPageIndex <= totalPages)
                currentPageIndex--;
            else
                currentPageIndex = totalPages;
        }
        public void SetCurrentPage_1()
        {
            currentPageIndex = 1;
        }
        public int CurrentPageIndex => currentPageIndex;
        public int TotalPages => totalPages;
    }
}
