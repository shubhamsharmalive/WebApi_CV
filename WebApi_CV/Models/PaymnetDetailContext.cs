using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CV.Models
{
    public class PaymnetDetailContext : DbContext
    {
        public PaymnetDetailContext(DbContextOptions<PaymnetDetailContext> options) : base(options)
        {

        }

        public DbSet<PaymentDetail> paymentDetails { get; set; }
    }
}
