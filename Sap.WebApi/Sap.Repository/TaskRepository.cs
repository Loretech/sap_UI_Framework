using Sap.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sap.Repository
{
    public class TaskRepository : ITaskRepository
    {
        public List<Task> GetTasks()
        {
            var taskList = new List<Task>();

            for (int i = 0; i < 10; i++)
            {
                taskList.Add(new Task()
                {
                    Id = Guid.NewGuid(),
                    Name = " Test" + (i + 1),
                    Icon = "fab fa-bug",
                    Description = "Description goes here for task" + (i + 1)
                });
            }

            taskList[0].Icon = "fab fa-searchengin";
            taskList[1].Icon = "fab fa-algolia";
            taskList[2].Icon = "far fa-address-book";
            taskList[3].Icon = "fas fa-anchor";
            taskList[4].Icon = "fas fa-running";
            taskList[5].Icon = "fas fa-atom";
            taskList[6].Icon = "fas fa-biohazard";
            taskList[7].Icon = "fab fa-audible";
            taskList[8].Icon = "fab fa-centercode";

            return taskList;
        }
    }
}
