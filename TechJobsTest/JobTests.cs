using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job testjob1;
        Job testjob2;
        Job fakeJob1;
        Job fakeJob2;
        Employer acme;
        Location desert;
        PositionType qa;
        CoreCompetency persistence;

        [TestInitialize]
        public void createJobObject()
        {
            Console.WriteLine("Initializing test...");
            testjob1 = new Job();
            testjob2 = new Job();

            acme = new Employer("ACME");
            desert = new Location("Desert");
            qa = new PositionType("Quality Control");
            persistence = new CoreCompetency("Persistence");

            fakeJob1 = new Job("Product tester", acme, desert, qa, persistence);
            fakeJob2 = new Job("Product tester", acme, desert, qa, persistence);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(testjob2.Id - testjob1.Id == 1);
        }
        [TestMethod]
        public void TestJobConstructorSetAllFields()
        {
            Assert.IsTrue(fakeJob1.Name == "Product tester");
            Assert.IsTrue(fakeJob1.EmployerName.Value == "ACME");
            Assert.IsTrue(fakeJob1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(fakeJob1.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(fakeJob1.JobType.Value == "Quality Control");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsTrue(fakeJob1.Equals(fakeJob2) == false);
        }
    }
}
