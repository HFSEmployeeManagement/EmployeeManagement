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
using SilverlightApplication3.ServiceReference1;
namespace SilverlightApplication3
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            //ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            //sc.DoWorkCompleted += new EventHandler<ServiceReference1.DoWorkCompletedEventArgs>(work);
            //sc.DoWorkAsync();
            sc.EmployeeCompleted += new EventHandler<ServiceReference1.EmployeeCompletedEventArgs>(Create);
            Entity empobject = new Entity();
            empobject.Employeeid = Convert.ToInt32(txid.Text);
            empobject.Firstname = Convert.ToString(txtfname.Text);
            empobject.Lastname = Convert.ToString(txtlname.Text);
            empobject.Birthdate = Convert.ToString(txtbirth.Text);
            empobject.Sex = Convert.ToString(txtsex.Text);
            sc.EmployeeAsync(empobject);
        }
        void Create(Object sender, ServiceReference1.EmployeeCompletedEventArgs ev)
        {
            if (ev.Result > -1)
            {
                //   lblresult.TextInputUpdate="Record Inserted Sucessfully";

                MessageBox.Show("Record Inserted Sucessfully", "Insert", MessageBoxButton.OK);
            }

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {


        }

        private void btnselect_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            sc.SelectAllCompleted += new EventHandler<ServiceReference1.SelectAllCompletedEventArgs>(Employee_Select);
            sc.SelectAllAsync();
        }

        void Employee_Select(object sender, SelectAllCompletedEventArgs se)
        {
            EmployeeGrid.ItemsSource = se.Result;
        }
    }
}

      

