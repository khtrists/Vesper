using System.ComponentModel.DataAnnotations;

namespace Vesper.Models
{
    public class Service
    {
        public int Id { get; set; }
       
        public string Title { get; set; }
       
        public string Desc { get; set; }
        public string Icon { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
