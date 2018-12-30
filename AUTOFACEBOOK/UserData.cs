using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace AUTOFACEBOOK
{
    [Serializable()]
    public class UserData
    {
        [XmlAttributeAttribute]
        public string Email { get; set; }
        [XmlAttributeAttribute]
        public string ID { get; set; }
        public string Token { get; set; }
        public List<string> Cookie { get; set; }
        public List<Thread> PostData { get; set; }
    }

    public class Thread
    {
        [XmlAttributeAttribute]
        public string ID { get; set; }
        [XmlText]
        public string Link { get; set; }
    }
}
