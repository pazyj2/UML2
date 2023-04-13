using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
   class Pizza
    {
        int _id;
        string _name;
        double _price;

        public Pizza()
        {
            _id = 0;
            _name = "";
            _price = 0;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} kr.";
        }

    }
}

