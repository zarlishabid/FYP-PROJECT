using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fyp_project.Models;
using System.Data.SqlClient;

namespace fyp_project.Models
{
    public class loginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Default
        void connectionString ()
        {
            con.ConnectionString = "data source = ZARLISH-ABID-SQLEXPRES; database=login; integrated security=SSPI;";
        }
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Verify(login log )
        {
            connectionString();
            con.Open();
            
            com.Connection = con;

            com.CommandText= "select * from table1 where username='" + acc.name +"' and password='"+acc.password+"'";
            dr= com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View();            }
            else
            {
                con.Close();
                return View();
            }
            
        }
        
    }
}