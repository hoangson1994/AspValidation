using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPValidation.Models
{
    public class ASPValidationContext : DbContext
    {
        public ASPValidationContext (DbContextOptions<ASPValidationContext> options)
            : base(options)
        {
        }

        public DbSet<ASPValidation.Models.Product> Product { get; set; }
    }
}
