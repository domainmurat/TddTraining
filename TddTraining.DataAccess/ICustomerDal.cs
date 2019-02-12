using System.Collections.Generic;
using TddTraining.Entities;

namespace TddTraining.DataAccess
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
    }
}