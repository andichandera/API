using API_Businesss.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Businesss.Services
{
    public class UserServices
    {
        public static ResponseDTO Adduser(UserDTO Obj)
        {
            ResponseDTO result = new ResponseDTO();
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-D8QB3JB\\MSSQL; Initial Catalog = API; User ID = sa; Password = dev"))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CRUD_USER", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NPM", Obj.NPM);
                        cmd.Parameters.AddWithValue("@Name", Obj.Name);
                        cmd.Parameters.AddWithValue("@Mode", "ADD");

                        using (var adap = new SqlDataAdapter(cmd))
                        {
                            adap.Fill(dt);
                        }
                    }
                }
                result.desc = "success";
                result.header = "200";
                return result;
            }
            catch (Exception ex)
            {
                result.desc = ex.Message;
                result.header = "400";
                return result;
            }


            
        }

        public static List<UserDTO> RetriveAlluser()
        {
            try
            {
                List<UserDTO> dtos = new List<UserDTO>();

                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-D8QB3JB\\MSSQL; Initial Catalog = API; User ID = sa; Password = dev"))
                {
                    // Header
                    using (SqlCommand cmd = new SqlCommand("spGetAlluser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (var adap = new SqlDataAdapter(cmd)) { adap.Fill(dt); }
                    }
                }
                dtos = dt.DataTableToList<UserDTO>();

                return dtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
