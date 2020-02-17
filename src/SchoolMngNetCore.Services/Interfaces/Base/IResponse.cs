namespace SchoolMngNetCore.Services.Interfaces.Base
{
    public interface IResponse
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
    }
}