using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Dialer
{
    class CellPhone:Phone
    {
        private string _name;
        private string _phoneNumber;
        private string _phoneType;
        public CellPhone(string name, string phoneNumber, string phoneType) : base(name, phoneNumber, phoneType)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _phoneType = phoneType;
        }
       override public string dial()
        {
            if (_phoneType == "2")
            {
                _phoneType = "1+";
            }
            return _name + " is being dialed using " + _phoneType + _phoneNumber;
        }  
        
}
}
