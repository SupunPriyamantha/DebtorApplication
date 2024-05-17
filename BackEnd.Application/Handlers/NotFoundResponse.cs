using Microsoft.AspNetCore.Http;

namespace BackEnd.Application.Handlers
{
    public class NotFoundResponse : BaseResponse
    {
        public NotFoundResponse()
            :base(StatusCodes.Status404NotFound)
        { 
        }
    }
}
