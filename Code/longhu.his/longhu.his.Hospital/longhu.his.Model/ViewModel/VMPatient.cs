using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model.ViewModel
{
    public partial class VMPatient
    {
        public VMPatient() { }

        public VMPatient(string name,string sex,int age,string idCard)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.IdentityCardNumber = idCard;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public string IdentityCardNumber { get; set; }        
    }
}
