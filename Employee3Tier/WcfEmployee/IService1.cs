using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EmployeeBusinesslayer;
using EmployeeEntity;


namespace WcfEmployee
{
    [ServiceContract]
    public interface IService1
    {

        //   [OperationContract]
        // string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        int CreateEmp(Entity emp);
        [OperationContract]
        List<Entity> getEmployee();


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {
        int Emp_id;
        string Fname;
        string Lname;
        string EmpSex;
        string Bdate;

        [DataMember]
        public string Birthdate
        {
            get { return Bdate; }
            set { Bdate = value; }
        }
        [DataMember]
        public int Employeeid
        {
            get { return Emp_id; }
            set { Emp_id = value; }
        }
        [DataMember]
        public string Firstname
        {
            get { return Fname; }
            set { Fname = value; }
        }
        [DataMember]
        public string Lastname
        {
            get { return Lname; }
            set { Lname = value; }
        }
        [DataMember]
        public string Sex
        {
            get { return EmpSex; }
            set { EmpSex = value; }
        }
    }
   
}
