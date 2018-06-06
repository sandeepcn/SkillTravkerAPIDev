using Newtonsoft.Json;
using System.Collections;
using System.IO;
using System.Reflection;
using SkillTrackerEntities;
using SkillTrackerWebAPI;
using SkillTrackerWebAPI.Controllers;
using NUnit.Framework;

namespace SkillTrackerTest
{
    [TestFixture]
    public class AssosciateTest
    {
        public static AssociateModel GetTestDataAssociate()
        {
            string FileLoc = @"TestData\Associate.json";
            string FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "").Replace("\\bin\\Debug", "");

            var jsonText = File.ReadAllText(Path.Combine(FilePath, FileLoc));
            var associate = JsonConvert.DeserializeObject<AssociateModel>(jsonText);
            return associate;
        }
        public static SkillModel GetTestDataSkill()
        {
            string FileLoc = @"TestData\Skill.json";
            string FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "").Replace("\\bin\\Debug", "");

            var jsonText = File.ReadAllText(Path.Combine(FilePath, FileLoc));
            var testSkill = JsonConvert.DeserializeObject<SkillModel>(jsonText);
            return testSkill;

        }

        [Test]
        public void TestAssociate()
        {
            AssociateController ctrl = new AssociateController();
            SkillController sCtrl = new SkillController();
            AssosciateResult aRes = new AssosciateResult();
            Skillresult sRes = new Skillresult ();
            SkillModel sm = GetTestDataSkill();
            sRes = sCtrl.Post(sm);
            string message = sRes.status.Message;
            Assert.AreEqual("Skill added successfully", message);
            Assert.IsNotNull(sCtrl.GetAllSkils());
            sm = sCtrl.GetSkillByName(sRes.skillModel);
            Assert.IsNotNull(sm);
            Status stat = sCtrl.DeleteSkill(sm);
            message = stat.Message;
            Assert.AreEqual("Skill deleted successfully", message);

        }
        
    }
}
