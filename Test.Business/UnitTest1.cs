using System;
using Business.Concrete;
using DataAccess.Abstract;
using Moq;
using Xunit;

namespace Test.Business
{
    public class UnitTest1
    {
        private static Mock<ICategoryDal> mock = new Mock<ICategoryDal>();
        private CategoryManager categoryManager = new CategoryManager(mock.Object);

        [Fact]
        public void Test1()
        {
            var result=categoryManager.GetCategoryList();
            Assert.Equal(1,result.Result.Count);

        }
    }
}
