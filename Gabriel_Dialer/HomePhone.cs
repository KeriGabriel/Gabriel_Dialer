using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Gabriel_Dialer
{
    class HomePhone : Phone

    {
        private string _name;
        private string _phoneNumber;
        private string _phoneType;
        public HomePhone(string name, string phoneNumber, string phoneType): base( name, phoneNumber, phoneType)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _phoneType = phoneType;   
        }      
    }
}
