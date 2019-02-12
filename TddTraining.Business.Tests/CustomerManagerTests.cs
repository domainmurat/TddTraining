using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddTraining.DataAccess;
using TddTraining.Entities;

namespace TddTraining.Business.Tests
{
    [TestClass]
    public class CustomerManagerTests
    {
        Mock<ICustomerDal> _mockCustomerDal;
        List<Customer> _dbCustomers;
        [TestInitialize]
        public void Start()
        {
            _mockCustomerDal = new Mock<ICustomerDal>();
            _dbCustomers = new List<Customer>()
            {
                new Customer(){Id=1,FirstName="Ali"},
                new Customer(){Id=2,FirstName="Ayhan"},
                new Customer(){Id=3,FirstName="Ahmet"},
                new Customer(){Id=4,FirstName="Ayfon"},
                new Customer(){Id=5,FirstName="Murat"}
            };
            _mockCustomerDal.Setup(x => x.GetAll()).Returns(_dbCustomers);
        }
        [TestMethod]
        public void Tum_Musteriler_Listelenebilmelidir()
        {
            //Arrange Test icin gerekli olan ortami olusturmak
            ICustomerService customerService = new CustomerManager(_mockCustomerDal.Object);
            //Act Aksiyon aliriz
            List<Customer> customers = customerService.GetAll();
            //Assert
            Assert.AreEqual(5, customers.Count);
            //Assert.AreEqual(4, customers.Count);
        }

        [TestMethod]
        public void A_Ile_Baslayan_4Kisi_Gelmelidir()
        {
            //Arrange Test icin gerekli olan ortami olusturmak
            ICustomerService customerService = new CustomerManager(_mockCustomerDal.Object);
            //Act Aksiyon aliriz
            List<Customer> customers = customerService.GetCustomersByInitial("A");
            //Assert
            Assert.AreEqual(4, customers.Count);
            //Assert.AreEqual(4, customers.Count);
        }

        [TestMethod]
        public void Kucuk_a_Ile_Baslayan_4Kisi_Gelmelidir()
        {
            //Arrange Test icin gerekli olan ortami olusturmak
            ICustomerService customerService = new CustomerManager(_mockCustomerDal.Object);
            //Act Aksiyon aliriz
            List<Customer> customers = customerService.GetCustomersByInitial("a");
            //Assert
            Assert.AreEqual(4, customers.Count);
            //Assert.AreEqual(4, customers.Count);
        }
    }
}
//Musteriler listelenebilmelidir
//Musteriler bas harflerine gore sayfalanabilmelidir

//Test Case
//5 elemanli bir listem olsun
