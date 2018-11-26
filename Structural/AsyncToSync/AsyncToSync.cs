using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Creational.AsyncToSync
{
    public class AsyncToSync
    {
        public static T RunWithoutContext<T>(Func<Task<T>> factory)
        {
            var task = default(Task<T>);

            if (null == SynchronizationContext.Current)
            {
                task = factory();
            }
            else
            {
                task = Task.Run(async () => await factory()
                    .ConfigureAwait(false));
            }

            return task.ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }
    }
}
//https://medium.com/bynder-tech/c-why-you-should-use-configureawait-false-in-your-library-code-d7837dce3d7f
//https://docs.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task.configureawait?view=netframework-4.7.2
//https://blogs.msdn.microsoft.com/benwilli/2017/02/09/an-alternative-to-configureawaitfalse-everywhere/
//https://stackoverflow.com/questions/13489065/best-practice-to-call-configureawait-for-all-server-side-code
//https://johnthiriet.com/configure-await/
//https://www.reddit.com/r/dotnet/comments/7nk0uj/when_to_use_configureawaitfalse/
//https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
//https://habr.com/post/162353/