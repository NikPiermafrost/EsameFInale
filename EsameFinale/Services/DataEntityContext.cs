using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsameFinale.Services
{
    public class DataEntityContext : DbContext
    {
        public DataEntityContext(DbContextOptions<DataEntityContext> options) : base(options)
        {

        }
    }
}
