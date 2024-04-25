// Api Response creation depending on data

using System.Net;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.ResponseExtention
{
    public class CreateResponseExtention
    {
        public static ApiResponse CreateResponse<T>(T data)
        {
            ApiResponse response = new();
            if(data == null)
            {
                response.ErrorMessage = ["Error occurred, data not found"];
                response.StatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                response.StatusCode = HttpStatusCode.OK;
                response.IsSuccess = true;
            }
            response.Result = data;
            return response;
        }

        public static ApiResponse CreateResponse<T>(List<T> dataList)
        {
            ApiResponse response = new();
            if (dataList.Count <= 0)
            {
                response.ErrorMessage = ["Error occurred while getting list"];
                response.StatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                response.StatusCode = HttpStatusCode.OK;
                response.IsSuccess = true;
            }
            response.Result = dataList;
            return response;
        }
    }
}