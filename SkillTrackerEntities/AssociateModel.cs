using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerEntities
{
    public class AssociateModel
    {
        public int Associate_ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Pic { get; set; }

        public bool? Gender { get; set; }

        public bool? Status_Green { get; set; }

        public bool? Status_Blue { get; set; }

        public bool? Status_Red { get; set; }

        public bool? Level_1 { get; set; }

        public bool? Level_2 { get; set; }

        public bool? Level_3 { get; set; }

        public string Remark { get; set; }

        public string Strength { get; set; }

        public string Weakness { get; set; }

        public virtual ICollection<AssociateSkill> AssociateSkills { get; set; }
    }
}
