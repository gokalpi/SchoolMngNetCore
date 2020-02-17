namespace SchoolMngNetCore.Services.Interfaces.Base
{
    public interface IPagedResponse<T> : IListResponse<T>
    {
        int TotalItems { get; set; }

        int PageCount { get; }
    }
}