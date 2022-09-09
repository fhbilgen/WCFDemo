using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WCFDemoAzure
{
    public enum Sex
    {
        Male,
        Female
    }

    [DataContract]
    [Serializable]
    public class PersonInfo
    {
        [DataMember, XmlElement(IsNullable =false, Order =0)]
        public string Name;
        [DataMember, XmlElement(IsNullable = false, Order = 1)]
        public string Surname;
        [DataMember, XmlElement(IsNullable = false, Order = 2)]
        public int Age;
    }
}
