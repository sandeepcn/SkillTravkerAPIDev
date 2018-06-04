using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerEntities
{
    public class SkillModel
    {
        public int Skill_ID { get; set; }

        public string Skill_Name { get; set; }

        public virtual ICollection<AssociateSkill> AssociateSkills { get; set; }
    }
}
