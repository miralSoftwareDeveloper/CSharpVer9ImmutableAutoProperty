using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVer9ImmutableAutoProperty
{
    internal class FriendVersion2
    {
        public string FirstName {get;}
        public string LastName {get;}

        public FriendVersion2(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
