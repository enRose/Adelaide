using System;
namespace VirtualAssistant.Utility
{
    public static class StrUtil
    {
        public static string OneOf(this string[] replies) =>
           replies[new Random().Next(0, replies.Length - 1)];
    }
}
