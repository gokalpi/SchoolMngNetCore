using System.Collections.Generic;

namespace SchoolMngNetCore.Services.Interfaces.Base
{
    public interface IListResponse<T> : IResponse
    {
        IEnumerable<T> Model { get; set; }
    }
}