using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess
{
    public class AssosciateDataAccess
    {
        public List<Associate> GetAllAssociates()
        {
            using (var context = new SkillTrackerContext())
            {
                return context.Associates.ToList();
            }
        }
        public Associate AddAssociate(Associate oAssociate)
        {
            using (var context = new SkillTrackerContext())
            {
                oAssociate = context.Associates.Add(oAssociate);
                context.SaveChanges();
                return oAssociate;
            }
        }
        public Associate UpdateAssociate(Associate oAssociate)
        {
            using (var context = new SkillTrackerContext())
            {
                oAssociate = context.Associates.Attach(oAssociate);
                context.Entry(oAssociate).State = EntityState.Modified;
                context.SaveChanges();
                return oAssociate;
            }
        }        
        public bool DeleteAssosciate(Associate objAssosciate)
        {
            using (var context = new SkillTrackerContext())
            {
                objAssosciate = context.Associates.FirstOrDefault(x => x.Associate_ID == objAssosciate.Associate_ID);
                context.Associates.Remove(objAssosciate);
                context.SaveChanges();
                return true;
            }
        }
    }
}
