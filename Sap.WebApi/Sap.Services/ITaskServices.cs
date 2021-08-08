using Sap.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Services
{
    public interface ITaskServices
    {
        List<TaskViewModel> GetTasks();
    }
}
