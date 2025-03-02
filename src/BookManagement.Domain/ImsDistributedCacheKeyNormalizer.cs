using Microsoft.Extensions.Options;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;

namespace BookManagement
{
    [Dependency(ReplaceServices = true)]
    public class ImsDistributedCacheKeyNormalizer : IDistributedCacheKeyNormalizer, ITransientDependency
    {
        protected AbpDistributedCacheOptions DistributedCacheOptions { get; }

        public ImsDistributedCacheKeyNormalizer(
            IOptions<AbpDistributedCacheOptions> distributedCacheOptions)
        {
            DistributedCacheOptions = distributedCacheOptions.Value;
        }

        public string NormalizeKey(DistributedCacheKeyNormalizeArgs args)
        {
            var normalizedKey = string.Empty;
            if (string.IsNullOrWhiteSpace(PrefixContext.Prefix.Value))
            {
                normalizedKey = $"{DistributedCacheOptions.KeyPrefix}{args.CacheName},{args.Key}";
            }
            else
            {
                normalizedKey = $"{PrefixContext.Prefix.Value}{args.CacheName},{args.Key}";
            }

            return normalizedKey;
        }
    }
}
