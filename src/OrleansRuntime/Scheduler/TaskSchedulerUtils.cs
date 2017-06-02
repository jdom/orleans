using System.Threading;
using System.Threading.Tasks;


namespace Orleans.Runtime.Scheduler
{
    internal class TaskSchedulerUtils
    {
        internal static Task WrapWorkItemAsTask(IWorkItem todo, ISchedulingContext context, TaskScheduler sched)
        {
            var task = new Task(state => RunWorkItemTask(todo, sched), context);
            return task;
        }

        internal static Task StartWorkItemAsTask(IWorkItem todo, ISchedulingContext context, TaskScheduler sched)
        {
            return Task.Factory.StartNew(state => RunWorkItemTask(todo, sched), context, CancellationToken.None, TaskCreationOptions.None, sched);
        }

        private static void RunWorkItemTask(IWorkItem todo, TaskScheduler sched)
        {
            try
            {
                RuntimeContext.SetExecutionContext(todo.SchedulingContext, sched);
                todo.Execute();
            }
            finally
            {
                RuntimeContext.ResetExecutionContext();
            }
        }
    }
}
