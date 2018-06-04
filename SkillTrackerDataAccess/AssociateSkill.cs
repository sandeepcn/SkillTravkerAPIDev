namespace SkillTrackerDataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AssociateSkill
    {
        [Key]
        public int AssociateSkillsId { get; set; }

        public int? Associate_ID { get; set; }

        public int? Skill_ID { get; set; }

        public short? SkillRating { get; set; }

        public virtual Associate Associate { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
