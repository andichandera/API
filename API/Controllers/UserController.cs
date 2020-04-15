
using API_Businesss.DataModel;
using API_Businesss.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public List<UserDTO> Get()
        {
            return UserServices.RetriveAlluser();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public ResponseDTO Post(AddNewUser value)
        {
            UserDTO Obj = new UserDTO();
            Obj.Name = value.Name;
            Obj.NPM = value.NPM;
            ResponseDTO returnsMessage = UserServices.Adduser(Obj);
            return returnsMessage;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}