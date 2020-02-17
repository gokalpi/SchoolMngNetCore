namespace SchoolMngNetCore.Services.Interfaces.Base
{
    public interface ISingleResponse<T> : IResponse
    {
        T Model { get; set; }
    }
}