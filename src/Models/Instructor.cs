using Dapper;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace Workforce.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Slack handle")]
        public string SlackHandle { get; set; }

        [Required]
        public string Specialty { get; set; }

        [Display(Name = "Instructor Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }
    }
}
