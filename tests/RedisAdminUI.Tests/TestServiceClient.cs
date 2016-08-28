using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using ServiceStack;

namespace RedisAdminUI.Tests
{
    public class TestServiceClient
        : IServiceClient
    {
        private readonly AppHostBase appHostBase;

        public TestServiceClient(AppHostBase appHostBase)
        {
            this.appHostBase = appHostBase;
        }

        public TResponse Send<TResponse>(object request)
        {
            return (TResponse)appHostBase.ExecuteService(request);
        }

        public TResponse Send<TResponse>(IReturn<TResponse> request)
        {
            throw new NotImplementedException();
        }

        public void Send(IReturnVoid request)
        {
            throw new NotImplementedException();
        }

        public List<TResponse> SendAll<TResponse>(IEnumerable<IReturn<TResponse>> requests)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, FileInfo fileToUpload, string mimeType)
        {
            throw new NotImplementedException();
        }

        public void AddHeader(string name, string value)
        {
            throw new NotImplementedException();
        }

        public void ClearCookies()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetCookieValues()
        {
            throw new NotImplementedException();
        }

        public void SetCookie(string name, string value, TimeSpan? expiresIn = null)
        {
            throw new NotImplementedException();
        }

        void IRestClient.Get(IReturnVoid request)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Get(IReturnVoid request)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Get(object request)
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResponse> GetLazy<TResponse>(IReturn<QueryResponse<TResponse>> queryDto)
        {
            throw new NotImplementedException();
        }

        void IRestClient.Delete(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Delete(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Delete(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Delete<TResponse>(IReturn<TResponse> request)
        {
            throw new NotImplementedException();
        }

        public TResponse Delete<TResponse>(object request)
        {
            throw new NotImplementedException();
        }

        public TResponse Delete<TResponse>(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        void IRestClient.Post(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Post(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Post(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Post<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Post<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Post<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            throw new NotImplementedException();
        }

        void IRestClient.Put(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Put(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Put(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Put<TResponse>(string relativeOrAbsoluteUrl, object requestDto)
        {
            throw new NotImplementedException();
        }

        void IRestClient.Patch(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Patch(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Patch(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Patch<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Patch<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse Patch<TResponse>(string relativeOrAbsoluteUrl, object requestDto)
        {
            throw new NotImplementedException();
        }

        void IRestClient.CustomMethod(string httpVerb, IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse CustomMethod(string httpVerb, IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse CustomMethod(string httpVerb, object requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse CustomMethod<TResponse>(string httpVerb, IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public TResponse CustomMethod<TResponse>(string httpVerb, object requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Head(IReturn requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Head(object requestDto)
        {
            throw new NotImplementedException();
        }

        public HttpWebResponse Head(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName, string mimeType)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFileWithRequest<TResponse>(Stream fileToUpload, string fileName, object request,
                                                        string fieldName = "upload")
        {
            throw new NotImplementedException();
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName,
                                                        object request, string fieldName = "upload")
        {
            throw new NotImplementedException();
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, FileInfo fileToUpload, object request)
        {
            throw new NotImplementedException();
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName, object request)
        {
            throw new NotImplementedException();
        }

        public void SendOneWay(object request)
        {
            appHostBase.ExecuteService(request);
        }

        public void SendOneWay(string relativeOrAbsoluteUrl, object request)
        {
            appHostBase.ExecuteService(request);
        }

        public void SendAllOneWay(IEnumerable<object> requests)
        {
            throw new NotImplementedException();
        }

        public void SetCredentials(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetAsync<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetAsync<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetAsync<TResponse>(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        Task IRestClientAsync.GetAsync(IReturnVoid requestDto)
        {
            return GetAsync(requestDto);
        }

        public Task<HttpWebResponse> GetAsync(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> DeleteAsync<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> DeleteAsync<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> DeleteAsync<TResponse>(string relativeOrAbsoluteUrl)
        {
            throw new NotImplementedException();
        }

        Task IRestClientAsync.DeleteAsync(IReturnVoid requestDto)
        {
            return DeleteAsync(requestDto);
        }

        public Task<HttpWebResponse> DeleteAsync(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PostAsync<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PostAsync<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PostAsync<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            throw new NotImplementedException();
        }

        Task IRestClientAsync.PostAsync(IReturnVoid requestDto)
        {
            return PostAsync(requestDto);
        }

        public Task<HttpWebResponse> PostAsync(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PutAsync<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PutAsync<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> PutAsync<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            throw new NotImplementedException();
        }

        Task IRestClientAsync.PutAsync(IReturnVoid requestDto)
        {
            return PutAsync(requestDto);
        }

        public Task<HttpWebResponse> PutAsync(IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, object requestDto)
        {
            throw new NotImplementedException();
        }

        Task IRestClientAsync.CustomMethodAsync(string httpVerb, IReturnVoid requestDto)
        {
            return CustomMethodAsync(httpVerb, requestDto);
        }

        public Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, string relativeOrAbsoluteUrl, object request)
        {
            throw new NotImplementedException();
        }

        public Task<HttpWebResponse> CustomMethodAsync(string httpVerb, IReturnVoid requestDto)
        {
            throw new NotImplementedException();
        }

        public void CancelAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> SendAsync<TResponse>(IReturn<TResponse> requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> SendAsync<TResponse>(object requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResponse>> SendAllAsync<TResponse>(IEnumerable<IReturn<TResponse>> requests)
        {
            throw new NotImplementedException();
        }

        public void GetAsync<TResponse>(string relativeOrAbsoluteUrl, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync<TResponse>(string relativeOrAbsoluteUrl, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            throw new NotImplementedException();
        }

        public void PostAsync<TResponse>(string relativeOrAbsoluteUrl, object request, Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            throw new NotImplementedException();
        }

        public void PutAsync<TResponse>(string relativeOrAbsoluteUrl, object request, Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            throw new NotImplementedException();
        }

        public void SendAsync<TResponse>(object request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public string SessionId { get; set; }
        public int Version { get; set; }
    }
}