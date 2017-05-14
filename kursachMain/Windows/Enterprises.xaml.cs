using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace kursachMain.Windows
{
    /// <summary>
    /// Логика взаимодействия для Enterprises.xaml
    /// </summary>
   
    public partial class Enterprises : Window
    {

        kursachEntities kurs = new kursachEntities();
        





        public Enterprises()
        {
            InitializeComponent();
        }
        //kursachDb db = new kursachDb();
        //Предприятия enterpr = new Предприятия();

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {


        }


        private void EnterprisesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }





      

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        string constr = "kursachMain.Properties.Settings.kursachConnectionString";
        //        SqlConnection con = new SqlConnection();
        //        con.ConnectionString = ConfigurationManager.ConnectionStrings[constr].ConnectionString;
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "Select Название,УНП,Адрес,Телефон from Предприятия";
        //        cmd.Connection = con;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        EnterprisesDataGrid.ItemsSource = dt.DefaultView;

        //        if (con != null)
        //            con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.GetBaseException();
        //    }
        //}

        private void Addres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ContactFace_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ID_Enterprise_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ID_Pacts_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ID_Year_Recrutment_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    enterpr.Название = NameBox.Text;
            //    enterpr.УНП = YNPBox.Text;
            //    enterpr.Адрес = Addres.Text;
            //    enterpr.Телефон = Phone.Text;
            //    enterpr.Эл__почта = Email.Text;
            //    enterpr.Контактное_лицо = ContactFaceBox.Text;
            //    db.Enterprices.Add(enterpr);
            //    db.SaveChanges();



            //}
            //catch (Exception ex)
            //{
            //    ex.GetBaseException();
            //}
        }

        private void Button_Click_savePlan(object sender, RoutedEventArgs e)
        {
            using (var context = new kursachEntities())
            {
                ПланНабора plan = new ПланНабора();
                plan.Год = Year.Text;
                plan.МаксКолвоСтудентов = CountStuds.Text;
                context.ПланНабора.Add(plan);
                context.SaveChanges();
            }
              
            
        }

        private void Button_Click_LoadPlan(object sender, RoutedEventArgs e)
        {
            var data = from x in kurs.ПланНабора select new {x.IDНабораНаГод,x.Год,x.МаксКолвоСтудентов };
            PlanDataGrid.ItemsSource = data.ToList();
        }

        private void YearPlanTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void CountStudTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void IDEnterpricesPactsTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void IDOfTakingOnYearTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveEnterpriceBtn(object sender, RoutedEventArgs e)
        {
            using (var context = new kursachEntities())
            {
                Предприятия enterpr = new Предприятия();
                if (NameBox.Text == string.Empty)
                {
               
                }
                enterpr.Название = NameBox.Text;
                enterpr.УНП = YNPBox.Text;
                enterpr.Адрес = Addres.Text;
                enterpr.Телефон = Phone.Text;
                enterpr.Эл__почта = Email.Text;
                enterpr.Контактное_лицо = ContactFaceBox.Text;
                enterpr.IDЗаключенныхДоговоров = int.Parse(IDEnterpricesPacts.Text);
                enterpr.IDНабораНаГод =  int.Parse(IDOfTakingOnYear.Text);
                context.Предприятия.Add(enterpr);
                context.SaveChanges();
            }
        }

        private void UpdateEnterpriceBtn(object sender, RoutedEventArgs e)
        {
            //var data = from x in kurs.Студенты select new { x.IDСтудента, x.ФИОСтудента, x.IDГруппы, x.НомерТелефона, x.НомерЗачетки };
            //StudentDataGrid.ItemsSource = data.ToList();
        
            var data = from x in kurs.Предприятия select new { x.ID_предприятия, x.Название, x.Адрес,
                x.Контактное_лицо, x.УНП, x.IDЗаключенныхДоговоров, x.IDНабораНаГод,x.Эл__почта};
            EnterprisesDataGrid.ItemsSource = data.ToList();
           

            
        }
    }
}
//cmd.CommandText = "insert into Предприятия(ID предприятия,Название,УНП,Адрес,Телефон,Эл_почта,Контактное лицо,IDЗаключенныхДоговоров,IDНабораНаГод) Values("
//    + this.ID_Enterprise.Text + ",'" + this.Name.Text + ",'" + this.YNP.Text + "','"
//    + this.Addres.Text + "'," + this.Phone.Text + ",'" + this.Email.Text +
//  ",'" + this.ID_Year_Recrutment.Text + ",'" + this.ID_Pacts.Text + "','" + this.ContactFace.Text + "','" + this.ID_Year_Recrutment.Text + ",'" + this.ID_Year_Recrutment.Text + "' )";