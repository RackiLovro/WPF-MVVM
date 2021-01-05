using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HourLogger
{
    public sealed class Database:XDocument
    {
        private static Database instance = null;
        private XDocument document;

        private Database()
        {
            this.document = XDocument.Load("database.xml");
        }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
    }
}
