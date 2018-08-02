using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib.PModels
{
    public class ProjectListModel
    {
        public List<ProjectModel> Projects { get; set; }
        public ProjectListModel()
        {
            Projects = new List<ProjectModel>();
        }
    }
}
