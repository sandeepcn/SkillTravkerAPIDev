using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess
{
    public class SkillsDataAccess
    {
        public List<Skill> GetAllSkills()
        {
            using (var context = new SkillTrackerContext())
            {
                return context.Skills.ToList();
            }
        }
        public Skill AddSkill(Skill oSkill)
        {
            using (var context = new SkillTrackerContext())
            {
                oSkill = context.Skills.Add(oSkill);
                context.SaveChanges();
                return oSkill;
            }
        }
        public Skill UpdateSkill(Skill oSkill)
        {
            using (var context = new SkillTrackerContext())
            {
                oSkill = context.Skills.Attach(oSkill);
                context.Entry(oSkill).State = EntityState.Modified;
                context.SaveChanges();
                return oSkill;
            }
        }
        public bool DeleteSkill(Skill oSkill)
        {
            using (var context = new SkillTrackerContext())
            {
                oSkill = context.Skills.FirstOrDefault(x => x.Skill_ID == oSkill.Skill_ID);
                context.Skills.Remove(oSkill);
                context.SaveChanges();
                return true;
            }
        }
        public Skill GetSkillBySkillDetail(Skill oSkill)
        {
            using (var context = new SkillTrackerContext())
            {
                return context.Skills.Where(s => s.Skill_Name == oSkill.Skill_Name).FirstOrDefault();
            }
        }
    }
}
