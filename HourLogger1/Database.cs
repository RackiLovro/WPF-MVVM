using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HourLogger
{
    public sealed class Database : XDocument
    {
        private static Database instance = null;
        private readonly XDocument _document;

        private Database()
        {
            this._document = XDocument.Load("database.xml");
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

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public XDocument Document
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        {
            get { return _document; }
        }

        public XElement Element(string elementName)
        {
            return _document.Element(elementName);
        }

        public void Save()
        {
            this._document.Save("database.xml");
        }
    }
}
