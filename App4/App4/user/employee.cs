using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Assets
{
    class employee
    {
        private long _StudentId;
        private string _FirstName;
        private string _LastName;
        private string _PhoneNumber;
        private string _Email;

        public long StudentId { get => StudentId; set => StudentId = value; }
        public string FirstName { get => FirstName; set => FirstName = value; }
        public string LastName { get => LastName; set => LastName = value; }
        public string PhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string Email { get => Email; set => Email = value; }
    }
}
