using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib.PModels
{
    public class ProjectModel
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public bool Success { get; set; }
    }
}
