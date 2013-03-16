using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using BusinessLayer;
using EmployeeEntity;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace EmployeeMGMTSilverlightApplication.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EmployeeService
    {
        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }
        [OperationContract]
        public int Employee(Entity ent)
        {

          
            EmployeeBusiness b = new EmployeeBusiness();
            return b.CreateEmp(ent);

        }
        [OperationContract]
        public List<Entity> SelectAll()
        {
            
            EmployeeBusiness bb = new EmployeeBusiness();
            return bb.SelectEmployee();


            //return getemp.ToList();
        }




        // Add more operations here and mark them with [OperationContract]
    }
}
