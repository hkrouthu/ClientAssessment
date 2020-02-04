using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAssessment.Models;

namespace TestAssessment.Controllers
{
    public class TrainingController : ApiController
    {
        private TestAssessmentEntities myEntity = new TestAssessmentEntities();
        // GET: api/Training
        public IEnumerable<TrainingData> Get()
        {
            return myEntity.TrainingDatas.AsEnumerable();
        }
        // POST: api/Training
        public void Post(TrainingData training)
        {
            if (ModelState.IsValid)
            {
                training.StartDate = Convert.ToDateTime(training.StartDate).AddDays(1);
                training.EndDate = Convert.ToDateTime(training.EndDate).AddDays(1);
                myEntity.TrainingDatas.Add(training);
                myEntity.SaveChanges();
            }
        } 
    }
}
