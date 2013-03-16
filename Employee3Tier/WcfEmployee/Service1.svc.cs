using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EmployeeBusinesslayer;
using EmployeeEntity;

namespace WcfEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection(@"Data Source=HFSTRSRV2\SQLEXPRESS;Initial Catalog=Employee;User ID=sa;Password=p@ssw0rd000");
        Employee emp = new Employee();
        Entity ent = new Entity();

        public int CreateEmp(Entity emp)
        {

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Emp(Employeeid,Firstname,Lastname,Birthdate,Sex) values(@Eid,@First,@Last,@Birth,@Esex)", con);
            //cmd.Parameters.AddWithValue("@Eid", emp.Employeeid);
            //cmd.Parameters.AddWithValue("@First", emp.Firstname);
            //cmd.Parameters.AddWithValue("@Last", emp.Lastname);
            //cmd.Parameters.AddWithValue("@Birth", emp.Birthdate);
            //cmd.Parameters.AddWithValue("@Esex", emp.Sex);
            //int i = cmd.ExecuteNonQuery();
            //con.Close();


            //if (i > 0)
            //{
            //    return "Record Insert Successfully";
            //}
            //else
            //{
            //    return " Error In Record Insertion";
            //}
            Business bl = new Business();
            return bl.CreateEmp(emp);



        }
        public List<Entity> getEmployee()
        {
            //List<Employee> EMP = new List<Employee>();

            //con.Open();
            //SqlCommand cmd;
            //string str = "Select * From Emp";
            //cmd = new SqlCommand(str, con);
            //SqlDataReader rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    Employee empdata = new Employee();
            //    empdata.Employeeid = Convert.ToInt32(rdr["Employeeid"]);
            //    empdata.Firstname = Convert.ToString(rdr["Firstname"]);
            //    empdata.Lastname = Convert.ToString(rdr["Lastname"]);
            //    empdata.Birthdate = Convert.ToString(rdr["Birthdate"]);
            //    empdata.Sex = Convert.ToString(rdr["Sex"]);
            //    EMP.Add(empdata);
            //}
            //con.Close();
            Business bl = new Business();

            return bl.SelectEmployee().ToList();
            //return EMP.ToList();
        }


    }
}
