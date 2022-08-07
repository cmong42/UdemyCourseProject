using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly2.Controllers
{
    public class ValuesController : Controller
    {
        private DataContext _context = new DataContext();
        // GET: api/values
        [HttpGet("api/customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        // GET api/values/5
        [HttpGet("api/customers/{id}")]
        public Customer Get(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id).ToList();
            if (customer == null)
            {
                throw new Exception();
            }
            return customer;
        }

        // POST api/values
        [HttpPost("api/customers/{customer}")]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        // PUT api/values/5
        [HttpPut("api/customers/{id}")]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }
            var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
            if (customerInDb == null)
            {
                throw new Exception();
            }

            customerInDb.FirstName = customer.FirstName;
            customerInDb.LastName = customer.LastName;
            customerInDb.Birthdate = customer.Birthdate;
            customerInDb.IsSubscribedNewsLetter = customer.IsSubscribedNewsLetter;
            customerInDb.MembershipTypeIds = customer.MembershipTypeIds;
            customerInDb.DiscountRate = customer.DiscountRate;
            customerInDb.DurationInMonths = customer.DurationInMonths;

            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("api/customers/{id}")]
        public void Delete(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customerInDb == null)
            {
                throw new Exception();
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}
