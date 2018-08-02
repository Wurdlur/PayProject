using ProjectLib.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib.PServiceFolder
{
    public interface IProjectService
    {
        ProjectListModel GetProjects();
        ProjectModel GetProject(int id);
        void AddProject(ProjectModel model);
        void DeleteProject(ProjectModel model);
        void UpdateProject(ProjectModel model);
    }
}
