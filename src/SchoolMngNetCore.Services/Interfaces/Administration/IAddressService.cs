using SchoolMngNetCore.Core.Paging;
using SchoolMngNetCore.Services.Interfaces.Base;
using SchoolMngNetCore.Services.Requests.Administration;
using SchoolMngNetCore.Services.Responses.Administration;
using System.Threading.Tasks;

namespace SchoolMngNetCore.Services.Interfaces
{
    public interface IAddressService
    {
        Task<IListResponse<AddressResponse>> GetAddressList();

        Task<IPagedList<AddressResponse>> SearchAddresss(PageQueryArgs args);

        Task<ISingleResponse<AddressResponse>> GetAddressById(int id);

        Task<ISingleResponse<AddressResponse>> CreateAddress(AddressRequest address);

        Task<IResponse> UpdateAddress(AddressRequest address);

        Task<IResponse> DeleteAddressById(int id);
    }
}