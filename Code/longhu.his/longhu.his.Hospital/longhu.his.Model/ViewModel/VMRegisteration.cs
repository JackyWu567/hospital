using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace longhu.his.Model.ViewModel
{
    public class VMRegisteration
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public string IdentityCardNumber { get; set; }

        public string Comments { get; set; }

        public string Department { get; set; }

        public string Doctor { get; set; }

        public decimal Pay { get; set; }

        public decimal RealPay { get; set; }

        public decimal ChargeBack { get; set; }

        public string RegisterDate { get; set; }
    }
}
