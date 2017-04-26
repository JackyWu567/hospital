using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longhu.his.Model.ViewModel
{
    public class Prescription
    {
        public int NO { get; set; }
        public string Name { get; set; }
        public List<PrescriptionDrug> GrugList { get; set; }
    }
}
