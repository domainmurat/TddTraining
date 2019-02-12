using System.Collections.Generic;
using System.Linq;
using TddTraining.DataAccess;
using TddTraining.Entities;

namespace TddTraining.Business
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetCustomersByInitial(string v)
        {
            return _customerDal.GetAll().Where(x => x.FirstName.ToUpper()
            .StartsWith(v.ToUpper())).ToList();
        }
    }
}