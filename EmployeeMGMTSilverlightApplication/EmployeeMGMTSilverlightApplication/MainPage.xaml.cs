using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using EmployeeMGMTSilverlightApplication.EmployeeReference;


namespace EmployeeMGMTSilverlightApplication
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnselsct_Click(object sender, RoutedEventArgs e)
        {
            EmployeeReference.EmployeeServiceClient sc = new EmployeeReference.EmployeeServiceClient();
         
            sc.SelectAllCompleted += new EventHandler<EmployeeReference.SelectAllCompletedEventArgs>(Employee_Select);
            sc.SelectAllAsync();
        }
        void Employee_Select(object sender, SelectAllCompletedEventArgs se)
        {
            EmpGrid.ItemsSource = se.Result;
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            Entity entobject = new Entity();
            entobject.Employeeid = Convert.ToInt32(txtid.Text);
            entobject.Firstname = Convert.ToString(txtfname.Text);
            entobject.Lastname = Convert.ToString(txtlname.Text);
            entobject.Birthdate = Convert.ToString(txtbirth.Text);
            entobject.Sex = Convert.ToString(txtsex.Text);
            EmployeeReference.EmployeeServiceClient sclient = new EmployeeServiceClient();
            sclient.EmployeeAsync(entobject);
            Clear();
            txtblock.Text = "Record Inserted Successfully";
        }
        void Create(object sender, EmployeeReference.EmployeeCompletedEventArgs e)
        {
            if (e.Result > -1)
            {
                MessageBox.Show("Record Inserted Sucessfully", "Insert", MessageBoxButton.OK);
                Clear();
                
            }

        }
        public void Clear()
        {
            txtid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtbirth.Text = "";
            txtsex.Text = "";
        }

   
        
    }
}
