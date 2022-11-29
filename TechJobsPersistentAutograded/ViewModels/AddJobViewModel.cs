using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistentAutograded.Models;

namespace TechJobsPersistentAutograded.ViewModels
{
    public class AddJobViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Job name must be between 1 and 100 characters.")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<SelectListItem> Skills { get; set; }
        public AddJobViewModel()
        {

        }
        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> possibleSkills)
        {
            Employers = new List<SelectListItem>();
            foreach(var employ in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employ.Id.ToString(),
                    Text = employ.Name
                });
               
            }

            Skills = new List<SelectListItem>();
            foreach(var skill in possibleSkills)
            {
                Skills.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name
                });
            }
        }
    }
}
