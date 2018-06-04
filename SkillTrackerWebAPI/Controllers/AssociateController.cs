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
    public class AssociateController : ApiController
    {
        AssociateBusiness oBusines = new AssociateBusiness();


        [HttpGet]
        [Route("api/getAllAssociates")]
        public IEnumerable<AssociateModel> Get()
        {
            return oBusines.GetAllAssociates();
        }



        [HttpPost]
        [Route("api/updateAssociate")]
        public AssosciateResult Post(AssociateModel oAsso)
        {
            return oBusines.UpdateAssociate(oAsso);

        }

        [HttpPost]
        [Route("api/deleteAssociate")]
        public Status DeleteUser(AssociateModel oAsso)
        {
            return oBusines.DeleteAssociate(oAsso);
        }
    }
}