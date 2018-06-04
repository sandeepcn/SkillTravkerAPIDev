using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillTrackerEntities;
using SkillTrackerDataAccess;

namespace SkillTrackerBusiness
{
    public class AssociateBusiness
    {
        public List<AssociateModel> GetAllAssociates()
        {
            AssosciateDataAccess assosciateRepo = new AssosciateDataAccess();
            return assosciateRepo.GetAllAssociates().Select(x => new AssociateModel
            {
                Associate_ID = x.Associate_ID,
                Name = x.Name,
                Email = x.Email,
                Mobile = x.Mobile,
                Pic = x.Pic,
                Gender = x.Gender,
                Status_Green = x.Status_Green,
                Status_Blue = x.Status_Blue,
                Status_Red = x.Status_Red,
                Level_1 = x.Level_1,
                Level_2 = x.Level_2,
                Level_3 = x.Level_3,
                Remark = x.Remark,
                Strength = x.Strength,
                Weakness = x.Weakness,
                AssociateSkills = null

            }).ToList();
        }

        public AssosciateResult UpdateAssociate(AssociateModel oAssociate)
        {
            Status oStatus = new Status();
            Associate asso = new Associate();
            AssosciateDataAccess assosciateRepo = new AssosciateDataAccess();
            asso.Associate_ID = oAssociate.Associate_ID;
            asso.Name = oAssociate.Name;
            asso.Email = oAssociate.Email;
            asso.Mobile = oAssociate.Mobile;
            asso.Pic = oAssociate.Pic;
            asso.Gender = oAssociate.Gender;
            asso.Status_Green = oAssociate.Status_Green;
            asso.Status_Blue = oAssociate.Status_Blue;
            asso.Status_Red = oAssociate.Status_Red;
            asso.Level_1 = oAssociate.Level_1;
            asso.Level_2 = oAssociate.Level_2;
            asso.Level_3 = oAssociate.Level_3;
            asso.Remark = oAssociate.Remark;
            asso.Strength = oAssociate.Strength;
            asso.Weakness = oAssociate.Weakness;
            asso.AssociateSkills = null;

            if (asso.Associate_ID == 0)
            {
                asso = assosciateRepo.AddAssociate(asso);
                oStatus = new Status() { Message = "Associate added successfully", Result = true };
            }
            else
            {
                asso.Associate_ID = oAssociate.Associate_ID;
                asso = assosciateRepo.UpdateAssociate(asso);
                oStatus = new Status() { Message = "Associate updated successfully", Result = true };
            }

            return new AssosciateResult()
            {
                status = oStatus,
                associateModel = new AssociateModel
                {
                    Associate_ID = asso.Associate_ID,
                    Name = asso.Name,
                    Email = asso.Email,
                    Mobile = asso.Mobile,
                    Pic = asso.Pic,
                    Gender = asso.Gender,
                    Status_Green = asso.Status_Green,
                    Status_Blue = asso.Status_Blue,
                    Status_Red = asso.Status_Red,
                    Level_1 = asso.Level_1,
                    Level_2 = asso.Level_2,
                    Level_3 = asso.Level_3,
                    Remark = asso.Remark,
                    Strength = asso.Strength,
                    Weakness = asso.Weakness,
                    AssociateSkills = null
                }
            };

        }
        public Status DeleteAssociate(AssociateModel oAssociate)
        {
            AssosciateDataAccess assosciateRepo = new AssosciateDataAccess();
            assosciateRepo.DeleteAssosciate(new Associate()
            {
                Associate_ID = oAssociate.Associate_ID
            });
            return new Status() { Message = "Associate deleted successfully", Result = true };
        }
    }
}
