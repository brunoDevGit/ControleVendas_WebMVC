using ControleDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVendas.Services
{
    public class SellerService
    {
        private readonly ControleDeVendasContext _context;
        public SellerService(ControleDeVendasContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
