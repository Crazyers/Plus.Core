using System;

namespace Plus.Http.Client.DynamicProxying
{
    public class DynamicHttpClientProxyConfig
    {
        public Type Type { get; }

        public string RemoteServiceName { get; }

        public DynamicHttpClientProxyConfig(Type type, string remoteServiceName)
        {
            Type = type;
            RemoteServiceName = remoteServiceName;
        }
    }
}