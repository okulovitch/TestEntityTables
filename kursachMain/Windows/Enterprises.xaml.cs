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








        public Enterprises()
        {
            InitializeComponent();
        }
        kursachDb db = new kursachDb();
        Предприятия enterpr = new Предприятия();

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {


        }


        private void EnterprisesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["kursachMain.Properties.Settings.kursachConnectionString"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Название,УНП,Адрес,Телефон from Предприятия";
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                EnterprisesDataGrid.ItemsSource = dt.DefaultView;

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

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
            using (var context = new kursachDb())
            {
                try
                {
                    //Специальности spec = new Специальности();
                    //spec.НазваниеСпециальности = NameSpec.Text;
                    //spec.НомерСпециальности = NomerSpec.Text;
                    //context.Spceialtes.Add(spec);
                    //context.SaveChanges();
                    ПланНабора plan = new ПланНабора();
                    plan.Год = Year.Text;
                    plan.МаксКолвоСтудентов = CountStuds.Text;
                    context.RecrutmentPlan.Add(plan);
                    context.SaveChanges();
                    MessageBox.Show("saved");
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                }

            }
        }

        private void Button_Click_LoadPlan(object sender, RoutedEventArgs e)
        {

        }
    }
}
//cmd.CommandText = "insert into Предприятия(ID предприятия,Название,УНП,Адрес,Телефон,Эл_почта,Контактное лицо,IDЗаключенныхДоговоров,IDНабораНаГод) Values("
//    + this.ID_Enterprise.Text + ",'" + this.Name.Text + ",'" + this.YNP.Text + "','"
//    + this.Addres.Text + "'," + this.Phone.Text + ",'" + this.Email.Text +
//  ",'" + this.ID_Year_Recrutment.Text + ",'" + this.ID_Pacts.Text + "','" + this.ContactFace.Text + "','" + this.ID_Year_Recrutment.Text + ",'" + this.ID_Year_Recrutment.Text + "' )";