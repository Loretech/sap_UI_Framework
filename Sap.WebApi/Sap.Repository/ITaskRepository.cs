using Sap.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sap.Repository
{
    public interface ITaskRepository
    {
        List<Task> GetTasks();
    }
}
