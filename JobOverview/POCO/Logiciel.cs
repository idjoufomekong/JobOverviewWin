using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview.POCO
{
    public class Logiciel
    {
        public string CodeLogiciel { get; set; }
        public string Nom { get; set; }
        public List<Module> ListeModule { get; set; }
        public List<Version> ListeVersion { get; set; }
    }

    public class Module
    {
        public string CodeModule { get; set; }
        public string Libelle { get; set; }
    }

    public class Version
    {
        public float NumeroVersion { get; set; }
        public short Millesime { get; set; }
        public DateTime DateSortiePrevue { get; set; }
        public short NumeroRelease { get; set; }
    }
}
