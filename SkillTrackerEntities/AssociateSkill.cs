using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerEntities
{
    public class AssociateSkill
    {
        public int AssociateSkillsId { get; set; }

        public int? Associate_ID { get; set; }

        public int? Skill_ID { get; set; }

        public short? SkillRating { get; set; }

        public virtual AssociateModel Associate { get; set; }

        public virtual SkillModel Skill { get; set; }
    }
}
