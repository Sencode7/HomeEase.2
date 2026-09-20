using Microsoft.AspNetCore.Mvc;
using HomeEase.Data;
using HomeEase.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeEase.Services
{
    public class ProductService 
    {
        private readonly ProductContext _context;
       
        public ProductService(ProductContext context)
        {
            _context = context;
        }



    }
}
