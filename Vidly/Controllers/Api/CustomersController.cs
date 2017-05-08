using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Vidly.Dtos;
using Vidly.Models;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //Get api/Customers
        public IHttpActionResult GetCustomers(string query=null)
        {
            var customerQuery = _context.Customers
                .Include(c => c.MembershipType);

            if (!string.IsNullOrWhiteSpace(query))
                customerQuery = customerQuery.Where(c => c.Name.Contains(query));

            var customerDtos=customerQuery
                .ToList()
                .Select(Mapper.Map<Customer,customerDto>);
            return Ok(customerDtos);
        }

        // Get /api/Customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var Customer = _context.Customers.SingleOrDefault(c=>c.Id==id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Customer,customerDto>(Customer));
        }

        // POst /ai/customers
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult CreateCustomer(customerDto CustomerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<customerDto, Customer>(CustomerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            CustomerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri+"/"+customer.Id),CustomerDto);
        }
        // PUT /api/Customers/1
        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateCustomer(int id,customerDto CustomerDto)
        {
            if (!ModelState.IsValid)
            {
                BadRequest();
            }
            
            var customerInDb = _context.Customers.SingleOrDefault(c=>c.Id==id);
            if (customerInDb == null)
                NotFound();
            Mapper.Map(CustomerDto, customerInDb);
           
            _context.SaveChanges();
            return Ok();
        }

        //Delete  /api/customers/1
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                NotFound();
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }

    }
}
