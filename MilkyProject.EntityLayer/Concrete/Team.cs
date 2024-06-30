using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Team
    {
        public int TeamId { get; set; }
        public string NameSurname { get; set; }
        public string? JobName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string SocialMediaUrl1 { get; set; }
        public string SocialMediaUrl2 { get; set; }
        public string SocialMediaUrl3 { get; set; }
    }
}
