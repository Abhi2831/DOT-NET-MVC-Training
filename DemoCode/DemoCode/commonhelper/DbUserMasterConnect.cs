using DemmoMVCWebApp.Models;
using DemoCode.Controllers;
using DemoCode.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoCode.CommonHelper
{
    public class DbUserMasterConnect
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public DbUserMasterConnect()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Abhishek"].ConnectionString);
            con.Open();
        }

        public int InsertUserData(UserMaster U)
        {
            if (U.Id == 0)
            {
                using (con)
                {
                    cmd = new SqlCommand("CreateNewAccount", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = U.Id;
                    cmd.Parameters.AddWithValue("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now.ToString("dd/MM/yyyy | hh:mm:ss tt");
                    cmd.Parameters.AddWithValue("@EditedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@DeletedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = U.FirstName;
                    cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = U.LastName;
                    cmd.Parameters.AddWithValue("@ContactNo", SqlDbType.VarChar).Value = U.ContactNo;
                    cmd.Parameters.AddWithValue("@EmailId", SqlDbType.VarChar).Value = U.EmailId;
                    cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = U.Password;
                    cmd.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = U.Gender;
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.Char).Value = U.Status;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                using (con)
                {
                    cmd = new SqlCommand("CreateNewAccount", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = U.Id;
                    cmd.Parameters.AddWithValue("@CreatedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@EditedAt", SqlDbType.VarChar).Value = DateTime.Now.ToString("dd/MM/yyyy | hh:mm:ss tt");
                    cmd.Parameters.AddWithValue("@DeletedAt", SqlDbType.VarChar).Value = null;
                    cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = U.FirstName;
                    cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = U.LastName;
                    cmd.Parameters.AddWithValue("@ContactNo", SqlDbType.VarChar).Value = U.ContactNo;
                    cmd.Parameters.AddWithValue("@EmailId", SqlDbType.VarChar).Value = U.EmailId;
                    cmd.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = U.Gender;
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.Char).Value = 'X';
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return 1;
        }



        public List<UserMaster> GetUserData(string OrderBy, string WhereClause)
        {
            List<UserMaster> ULst = new List<UserMaster>();
            using (con)
            {
                cmd = new SqlCommand("UserRecords", con);
                cmd.Parameters.AddWithValue("@OrderBy", SqlDbType.VarChar).Value = OrderBy;
                cmd.Parameters.AddWithValue("@WhereClause", SqlDbType.VarChar).Value = WhereClause;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserMaster U = new UserMaster();
                    U.setId(Convert.ToInt32(rdr["Id"]));
                    U.setFirstName(Convert.ToString(rdr["FirstName"]));
                    U.setLastName(Convert.ToString(rdr["LastName"]));
                    U.setEmailId(Convert.ToString(rdr["EmailId"]));
                    U.setContactNo(Convert.ToString(rdr["ContactNo"]));
                    U.setGender(Convert.ToChar(rdr["Gender"]));
                    U.setStatus(Convert.ToChar(rdr["Status"]));
                    U.setCreatedAt(Convert.ToString(rdr["CreatedAt"]));
                    U.setEditedAt(Convert.ToString(rdr["EditedAt"]));
                    U.setDeletedAt(Convert.ToString(rdr["DeletedAt"]));
                    ULst.Add(U);
                }
            }
            return ULst;
        }
        public List<UserMaster> GetUserDat(string OrderBy, string WhereClause)
        {
            List<UserMaster> Rlst = new List<UserMaster>();
            using (con)
            {
                cmd = new SqlCommand("UserRecords", con);
                cmd.Parameters.AddWithValue("@OrderBy", SqlDbType.VarChar).Value = OrderBy;
                cmd.Parameters.AddWithValue("@WhereClause", SqlDbType.VarChar).Value = WhereClause;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserMaster IR = new UserMaster();
                    IR.setId(Convert.ToInt32(reader["id"]));
                    IR.setFirstName(Convert.ToString(reader["FirstName"]));
                    IR.setLastName(Convert.ToString(reader["LastName"]));
                    IR.setEmailId(Convert.ToString(reader["EmailId"]));
                    IR.setContactNo(Convert.ToString(reader["ContactNo"]));
                    IR.setGender(Convert.ToChar(reader["Gender"]));
                    IR.setStatus(Convert.ToChar(reader["Status"]));
                    IR.setCreatedAt(Convert.ToString(reader["CreatedAt"]));
                    IR.setEditedAt(Convert.ToString(reader["EditedAt"]));
                    IR.setDeletedAt(Convert.ToString(reader["DeletedAt"]));
                    Rlst.Add(IR);
                }
            }
            return Rlst;
        }

        public int UpdateUserStatus(UserMaster U)
        {
            if (U.Id != 0)
            {
                using (con)
                {
                    cmd = new SqlCommand("UpdateUserStatus_Ab", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = U.Id;
                    cmd.Parameters.AddWithValue("@DeletedAt", SqlDbType.VarChar).Value = DateTime.Now.ToString("dd/MMM/YYYY | hh:mm:ss tt");
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.Char).Value = U.Status;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return 1;
        }
        public List<UserChartResponseModel> GetUserChartData(string SelectAsLabel, string GroupBy)
        {
            List<UserChartResponseModel> ULst = new List<UserChartResponseModel>();
            using (con)
            {
                cmd = new SqlCommand("GetUserRecordsChart", con);
                cmd.Parameters.AddWithValue("@SelectAsLabel", SqlDbType.VarChar).Value = SelectAsLabel;
                cmd.Parameters.AddWithValue("@GroupBy", SqlDbType.VarChar).Value = GroupBy;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserChartResponseModel U = new UserChartResponseModel();
                    U.setLabel(Convert.ToString(rdr["label"]));
                    U.setValue(Convert.ToInt32(rdr["value"]));
                    ULst.Add(U);
                }
            }
            return ULst;
        }
    }
}



   