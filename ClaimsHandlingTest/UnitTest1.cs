using NUnit.Framework;
using claimsHandling.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;
using claimsHandling.Data;

namespace ClaimsHandlingTest
{
    public class Tests
    {
        
        //    public List<claimsHandling.Models.User> GetAllUsers()
        //    {
        //        var mockSet = new Mock<DbSet<claimsHandling.Models.User>>();
        //        mockSet.As<IQueryable<claimsHandling.Models.User>>().Setup(m => m.Provider).Returns(data.Provider);
        //        mockSet.As<IQueryable<claimsHandling.Models.User>>().Setup(m => m.Expression).Returns(data.Expression);
        //        mockSet.As<IQueryable<claimsHandling.Models.User>>().Setup(m => m.ElementType).Returns(data.ElementType);
        //        mockSet.As<IQueryable<claimsHandling.Models.User>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        //        var mockContext = new Mock<InterviewContext>();
        //        mockContext.Setup(c => c.Users).Returns(mockSet.Object);

        //        var service = new CustomerService(mockContext.Object);
        //        return service.GetAllCustomers();
            
        //}

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}