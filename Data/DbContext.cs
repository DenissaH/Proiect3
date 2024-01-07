using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Data
{
    class DbContext
    {
        private DbSet<Materie> materii;

        public DbSet<Materie> Materii { get => materii; set => materii = value; }
    }
}
