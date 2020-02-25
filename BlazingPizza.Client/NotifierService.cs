using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class NotifierService
    {
        /// <summary>
        /// NotifierService serves as communication between components to update state.
        /// In login display there is a onclick that triggers a method that runs Update(), this then Invokes
        /// a notify function in index or wherever that he state has changed and needs to update. 
        /// </summary>
        /// <returns>Notify event function that contains a task</returns>
        public async Task Update()
        {
            if (Notify != null)
            {
                await Notify.Invoke();
            }
        }

        public event Func<Task> Notify;
    }
}
