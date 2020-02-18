using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AlipioWesley.EmployeeQueries.Windows.DAL
{
    public class DataAcess : DbContext
    {
        public DataAcess() : base("myConnectionString")
        {}
    }
}
