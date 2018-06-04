using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SkillTrackerBusiness;
using SkillTrackerEntities;

namespace SkillTrackerWebAPI.Controllers
{
    public class SkillController : ApiController
    {
        SkillBusiness oBusines = new SkillBusiness();
        [HttpGet]
        [Route("api/getAllSkills")]
        public IEnumerable<SkillModel> Get()
        {
            return oBusines.GetAllSkils();
        }

        [HttpPost]
        [Route("api/updateSkill")]
        public Skillresult Post(SkillModel oSkill)
        {
            return oBusines.UpdateSkill(oSkill);

        }

        [HttpPost]
        [Route("api/deleteSkill")]
        public Status DeleteUser(SkillModel oSkill)
        {
            return oBusines.DeleteSkill(oSkill);
        }
    }
}