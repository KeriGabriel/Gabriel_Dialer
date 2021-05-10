using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Keri Gabriel
// IT112
// NOTES: notes the instructor should read
// BEHAVIORS NOT IMPLIMENTED AND WHY: 
namespace Gabriel_Dialer
{
    class Phone
    {
        private string _name;
        private string _phoneNumber;
        private string _phoneType;
    public Phone(string name, string phoneNumber, string phoneType)
        {
            _name= name;
            _phoneNumber= phoneNumber;
            _phoneType= phoneType;
        }
        virtual public string dial()
        {
            return _name +" is being dialed using "+_phoneNumber;
        }       
    }
}