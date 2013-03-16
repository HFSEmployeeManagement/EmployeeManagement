using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using EmployeeBusinesslayer;
using EmployeeDatalayer;
using EmployeeEntity;

namespace SilverlightApplication3.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        SqlConnection con = new SqlConnection(@"Data Source=HFSTRSRV2\SQLEXPRESS;Initial Catalog=Employee;User ID=sa;Password=p@ssw0rd000");
        Emp e = new Emp();
        Entity empent = new Entity();
        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }
        [OperationContract]
        public int Employee(Entity ent)
        {

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Emp(Employeeid,Firstname,Lastname,Birthdate,Sex) values(@Eid,@First,@Last,@Birth,@Esex)", con);
            //cmd.Parameters.AddWithValue("@Eid", e.Employeeid);
            //cmd.Parameters.AddWithValue("@First", e.Firstname);
            //cmd.Parameters.AddWithValue("@Last", e.Lastname);
            //cmd.Parameters.AddWithValue("@Birth", e.Birthdate);
            //cmd.Parameters.AddWithValue("@Esex", e.Sex);
            //int i = cmd.ExecuteNonQuery();
            //// Add your operation implementation here
            //return 1;
            ////return e.id.ToString();
            Business b = new Business();
            return b.CreateEmp(ent);

        }
        [OperationContract]
        public List<Entity> SelectAll()
        {
            //List<Emp> getemp = new List<Emp>();

            //con.Open();
            //SqlCommand cmd;
            //string str = "Select * From Emp";
            //cmd = new SqlCommand(str, con);
            //SqlDataReader rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    Emp empdata = new Emp();
            //    empdata.Employeeid = Convert.ToInt32(rdr["Employeeid"]);
            //    empdata.Firstname = Convert.ToString(rdr["Firstname"]);
            //    empdata.Lastname = Convert.ToString(rdr["Lastname"]);
            //    empdata.Birthdate = Convert.ToString(rdr["Birthdate"]);
            //    empdata.Sex = Convert.ToString(rdr["Sex"]);
            //    getemp.Add(empdata);
            //}
            //con.Close();
            Business bb = new Business();
            return bb.SelectEmployee();


            //return getemp.ToList();
        }



        // Add more operations here and mark them with [OperationContract]
    }

    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Emp
    {
        public int Employeeid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Birthdate { get; set; }
        public string Sex { get; set; }
    }
}
