using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Businesss.DataModel
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int NPM { get; set; }

        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }


        public UserDTO()
        {

        }
    }

    public class AddNewUser
    {
        public int NPM { get; set; }
        public string Name { get; set; }

        public AddNewUser()
        {

        }
    }
}
