using System;
using System.Collections.Generic;
using System.Text;

namespace Sap.Repository.Domain
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskType { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
