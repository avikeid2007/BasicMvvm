using BasicMvvm.Commands.Abstraction;
using System;
using System.Threading.Tasks;

namespace BasicMvvm.Commands
{
    public static class TaskUtilities
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="errorHandler"></param>
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler errorHandler)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                errorHandler?.HandleError(ex);
            }
        }
    }
}
