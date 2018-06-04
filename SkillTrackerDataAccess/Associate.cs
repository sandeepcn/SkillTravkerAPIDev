namespace SkillTrackerDataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Associate")]
    public partial class Associate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Associate()
        {
            AssociateSkills = new HashSet<AssociateSkill>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Associate_ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(500)]
        public string Pic { get; set; }

        public bool? Gender { get; set; }

        public bool? Status_Green { get; set; }

        public bool? Status_Blue { get; set; }

        public bool? Status_Red { get; set; }

        public bool? Level_1 { get; set; }

        public bool? Level_2 { get; set; }

        public bool? Level_3 { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(500)]
        public string Strength { get; set; }

        [StringLength(500)]
        public string Weakness { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssociateSkill> AssociateSkills { get; set; }
    }
}
