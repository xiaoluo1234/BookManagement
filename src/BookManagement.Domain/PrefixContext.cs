using System.Threading;

namespace BookManagement
{
    public static class PrefixContext
    {
        public static ThreadLocal<string> Prefix { get; set; } = new ThreadLocal<string>();
    }
}
