using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BladeBlazorASP.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Project Image")]
        public string ProjectImg { get; set; }
        [DisplayName("Project Description")]
        public string ProjectDescription { get; set; }
        public Project()
        {
            
        }
        public Project( string projectName,string projectImg,string projectDescription)
        {
            ProjectName = projectName;
            ProjectImg = projectImg;
            ProjectDescription = projectDescription;
            
        }
    }
}
