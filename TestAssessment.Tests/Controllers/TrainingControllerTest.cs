using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAssessment;
using TestAssessment.Controllers;
using TestAssessment.Models;

namespace TestAssessment.Tests.Controllers
{
    [TestClass]
    public class TrainingControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            TrainingController controller = new TrainingController();

            // Act
            IEnumerable<TrainingData> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
             
           
        }

       
        [TestMethod]
        public void Post()
        {
            // Arrange
            TrainingController controller = new TrainingController();

            TrainingData training = new TrainingData();
            training.TrainingName = "UnitTest";
            training.StartDate = Convert.ToDateTime("02-03-2019");
            training.EndDate = Convert.ToDateTime("05-03-2019");
            // Act
            controller.Post(training);

            // Assert

           
        }

         

         
    }
}
