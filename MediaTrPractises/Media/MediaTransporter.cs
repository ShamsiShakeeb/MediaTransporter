using System;
using System.Linq;
using System.Reflection;

namespace MediaTrPractises.Media
{
    public class MediaTransporter<TRequest, TResponse> : IMediaTransporter<TRequest, TResponse>
    {
        private readonly IServiceProvider _serviceProvider;
        public MediaTransporter(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public TResponse Send()
        {
            return MethodInvoke();
        }

        public TResponse Send<TRequestModel>(TRequestModel requestModel) where TRequestModel : class, new()
        {
            object[] parms = { requestModel };
            return MethodInvoke(parms);
        }
        public TResponse Send(object[] prams)
        {
            return MethodInvoke(prams);
        }

        private TResponse MethodInvoke(object[] parms = null)
        {
            var type = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                        from t in assembly.GetTypes()
                        where t.Name == typeof(TRequest).Name
                        select t).FirstOrDefault();

            if (type == null)
                throw new InvalidOperationException("Type not found");

            var service = _serviceProvider.GetService(type);

            MethodInfo methodInfo = type.GetMethod("Handler");

            if (methodInfo == null)
            {
                throw new InvalidOperationException("Command Query Service Does not contains Handler Method");
            }

            var data = methodInfo.Invoke(service, parms);

            return (TResponse)data;
        }
        

    }
}

