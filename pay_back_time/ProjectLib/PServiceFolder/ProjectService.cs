using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDAL;
using ProjectLib.PModels;

namespace ProjectLib.PServiceFolder
{
    public class ProjectService : IProjectService
    {

        public ProjectListModel GetProjects()
        {
            ProjectListModel model = new ProjectListModel();
            using (var db = new ProjectsEntities())
            {
                var query = db.UserProjects.Select(x => x);
                var weaponList = query.ToList();
                weaponList.ForEach(project =>
                {
                    model.Projects.Add(
                        new ProjectModel
                        {
                            ProjectID = project.ID,
                            Name = project.ProjectName,
                            Owner = project.ProjectOwner,
                            Details = project.ProjectDetail,
                            Image = project.ProjectImage,
                            Success = project.Successful
                        }
                    );
                });
            }
            return model;
        }

        public ProjectModel GetProject(int id)
        {
            return GetProjects().Projects.Where(x => x.ProjectID == id).First();
        }

        public void AddProject(ProjectModel model)
        {
            using (var db = new ProjectsEntities())
            {
                var newProject = new UserProject()
                {
                    ProjectName = model.Name,
                    ProjectOwner = model.Owner,
                    ProjectDetail = model.Details,
                    Successful = model.Success,
                    ProjectImage = model.Image,
                };
                db.UserProjects.Add(newProject);
                db.SaveChanges();
            }
        }

        public void DeleteProject(ProjectModel model)
        {
            using (var db = new ProjectsEntities())
            {
                var deleteWeapon = db.UserProjects.Where(x => x.ID == model.ProjectID).First();
                db.UserProjects.Remove(deleteWeapon);
                db.SaveChanges();
            }
        }

        public void UpdateProject(ProjectModel model)
        {
            using (var db = new ProjectsEntities())
            {
                var projectToUpdate = db.UserProjects.Where(x => x.ID == model.ProjectID).First();
                projectToUpdate.ProjectName = model.Name;
                projectToUpdate.ProjectOwner = model.Owner;
                projectToUpdate.ProjectDetail = model.Details;
                projectToUpdate.ProjectImage = model.Image;
                projectToUpdate.Successful = model.Success;
                db.SaveChanges();
            }
        }
    }
}
