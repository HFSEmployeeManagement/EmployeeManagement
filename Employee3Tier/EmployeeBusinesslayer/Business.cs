using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDatalayer;
using EmployeeEntity;

namespace EmployeeBusinesslayer
{
    public class Business
    { EmployeeData edata = new EmployeeData();
        public int CreateEmp(Entity ent)
        {

            return edata.CreateEmp(ent);
        }
        
        public List<Entity> SelectEmployee()
        {
            EmployeeData data = new EmployeeData();
            return data.SelectEmp();
        }
        public int GetId(Entity ent)
        {
            List<int> idlist = new List<int>();

            idlist= edata.GetEmployeeID();
            int newid = Convert.ToInt32(ent.Employeeid);
            foreach (int dataid in idlist)
            {
                if (newid == dataid)
                {
                    return 0;
                }
                
               
            }
            return 1;
                
            }
        public int CheckAge(Entity date)
        {
            DateTime dt = Convert.ToDateTime(date.Birthdate);
            int birthyear = dt.Year;
            string currentdate = DateTime.Now.ToString();
            DateTime currentdt = Convert.ToDateTime(currentdate);
            int currentyear = currentdt.Year;
            int di = currentyear - birthyear;
            //int d = 24;
            if (di>18)
            {
                return 1;
            }
            return 0;
        }
        public int CheckObject(Entity entobject)
        {
           
            if (entobject.Employeeid==null)
            {
                return 1;
            }
            return 0;
        }
    }
}
