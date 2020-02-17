using SchoolMngNetCore.Services.Interfaces.Base;
using System.Collections.Generic;

namespace SchoolMngNetCore.Services.Responses.Base
{
    public class PagedResponse<T> : IPagedResponse<T>
    {
        public PagedResponse()
        {
        }

        public PagedResponse(string message)
        {
            IsSuccessful = false;
            Message = message;
            Model = default;
        }

        public PagedResponse(IEnumerable<T> model)
        {
            IsSuccessful = true;
            Message = default;
            Model = model;
        }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Model { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public int TotalItems { get; set; }

        public int PageCount
            => TotalItems < PageSize ? 1 : (int)(((double)TotalItems / PageSize) + 1);
    }
}