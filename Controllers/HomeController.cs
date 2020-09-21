using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlindLowVisionProject.Models;
using BlindLowVisionProject.ViewModels;

namespace BlindLowVisionProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public ViewResult Index()
        {
            var model = _customerRepository.GetAllCustomers();
            return View(model);
        }       
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Customer = _customerRepository.GetCustomer(1),
                PageTitle = "Customer Details"
            };
            
            return View(homeDetailsViewModel);
        }
    }
}
