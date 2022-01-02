
namespace MediaTrPractises.Media
{
    public interface IMediaTransporter<TRequest, TResponse> 
    {
        TResponse Send();
        TResponse Send<TRequestModel>(TRequestModel requestModel = null) where TRequestModel : class , new();
        TResponse Send(object[] prams);


    }
}
