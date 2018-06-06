using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillTrackerEntities;
using SkillTrackerDataAccess;

namespace SkillTrackerBusiness
{
    public class SkillBusiness
    {
        public List<SkillModel> GetAllSkils()
        {
            SkillsDataAccess repo = new SkillsDataAccess();
            return repo.GetAllSkills().Select(x => new SkillModel
            {
                Skill_ID = x.Skill_ID,
                Skill_Name = x.Skill_Name,
                //AssociateSkills = null
            }).ToList();
        }
        public Skillresult UpdateSkill(SkillModel objSkill)
        {
            Status oStatus = new Status();
            Skill oSkill = new Skill();
            SkillsDataAccess repo = new SkillsDataAccess();
            oSkill.Skill_ID = objSkill.Skill_ID;
            oSkill.Skill_Name = objSkill.Skill_Name;
            
            oSkill.AssociateSkills = null;

            if (oSkill.Skill_ID == 0)
            {
                oSkill = repo.AddSkill(oSkill);
                oStatus = new Status() { Message = "Skill added successfully", Result = true };
            }
            else
            {
                oSkill.Skill_ID = objSkill.Skill_ID;
                oSkill = repo.UpdateSkill(oSkill);
                oStatus = new Status() { Message = "Skill updated successfully", Result = true };
            }

            return new Skillresult()
            {
                status = oStatus,
                skillModel = new SkillModel
                {
                    Skill_ID = oSkill.Skill_ID,
                    Skill_Name = oSkill.Skill_Name,
                    //AssociateSkills = null
                }
            };

        }
        public Status DeleteSkill(SkillModel objSkill)
        {
            SkillsDataAccess repo = new SkillsDataAccess();
            repo.DeleteSkill(new Skill()
            {
                Skill_ID = objSkill.Skill_ID
            });
            return new Status() { Message = "Skill deleted successfully", Result = true };
        }
    }
}
