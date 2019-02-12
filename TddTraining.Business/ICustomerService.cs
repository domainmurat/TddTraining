using System.Collections.Generic;
using TddTraining.Entities;

namespace TddTraining.Business
{
    public interface ICustomerService
    {
        System.Collections.Generic.List<Customer> GetAll();
        List<Customer> GetCustomersByInitial(string v);
    }
}