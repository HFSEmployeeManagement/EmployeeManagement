using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EmployeeEntity;

namespace EmployeeDatalayer
{
    public class EmployeeData
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=hfstrsrv2\sqlexpress;Initial Catalog=Employee;User ID=sa;Password=p@ssw0rd000");

        public int CreateEmp(Entity entemp)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Emp(Employeeid,Firstname,Lastname,Birthdate,Sex) values(@id,@first,@Last,@Birth,@Sex)", con);
            cmd.Parameters.AddWithValue("@id", entemp.Employeeid);
            cmd.Parameters.AddWithValue("@First", entemp.Firstname);
            cmd.Parameters.AddWithValue("@Last", entemp.Lastname);
            cmd.Parameters.AddWithValue("@Birth", entemp.Birthdate);
            cmd.Parameters.AddWithValue("@Sex", entemp.Sex);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
            //if (i > 0)
            //{
            //    return "Record  Inserted Sucessfully";
            //}
            //else
            //{
            //    return "Error In Record Insertion";
            //}

        }
        public List<Entity> SelectEmp()
        {
            con.Open();
            List<Entity> listemp = new List<Entity>();
            SqlCommand cmd = new SqlCommand("select * from Emp", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Entity ent = new Entity();
                ent.Employeeid = Convert.ToInt32(rdr[0]);
                ent.Firstname = Convert.ToString(rdr[1]);
                ent.Lastname = Convert.ToString(rdr[2]);
                ent.Birthdate = Convert.ToString(rdr[3]);
                ent.Sex = Convert.ToString(rdr[4]);
                listemp.Add(ent);
            }
            return listemp.ToList();
        }
        public List<int> GetEmployeeID()
        {
            con.Open();
            List<int> id=new List<int>();
            SqlCommand cmdid=new SqlCommand("select Employeeid from Emp",con);
            SqlDataReader rdrid=cmdid.ExecuteReader();
           while(rdrid.Read())
           {
               //EmployeeId eid=new EmployeeId();
               id.Add(Convert.ToInt32(rdrid[0]));
              
           }

            return id.ToList();
        }

    }
}
