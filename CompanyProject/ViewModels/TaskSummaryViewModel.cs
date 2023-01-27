using System.Runtime.Serialization;
using System.Xml.Linq;

namespace CompanyProject.Models
{
    [DataContract]
    public class TaskSummaryViewModel
    {
        [DataMember(Name = "y")]
        public double Hours { get; set; }

        [DataMember(Name = "label")]
        public string Date { get; set; }
    }
}
