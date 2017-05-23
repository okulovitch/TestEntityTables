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
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;



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
            string specializationYear = @"^[1-9][0-9]{3}$";
            string spetializationStudCount = @"[0-9]";
            Regex YearPlan = new Regex(specializationYear);
            Regex StudCount = new Regex(spetializationStudCount);
            using (var context = new kursachEntities())
            {
              
              
                ПланНабора plan = new ПланНабора();
                var max = (from x in kurs.ПланНабора select x.IDНабораНаГод).ToList().Max();
                plan.IDНабораНаГод = max + 1;
                if (!YearPlan.IsMatch(Year.Text) && (!StudCount.IsMatch(CountStuds.Text)))
                {
                   PlanYearRegular.Foreground = new SolidColorBrush(Colors.Red);
                    PlanYearRegular.Content = "неверный формат года";
                   StudentsCountRegular.Foreground = new SolidColorBrush(Colors.Red);
                   StudentsCountRegular.Content = "используйте числа 1-9";

                }
                else if (!YearPlan.IsMatch(Year.Text))
                {
                    PlanYearRegular.Foreground = new SolidColorBrush(Colors.Red);
                    PlanYearRegular.Content = "неверный формат года";
                }
                else if (!StudCount.IsMatch(CountStuds.Text))
                {
                    StudentsCountRegular.Foreground = new SolidColorBrush(Colors.Red);
                    StudentsCountRegular.Content = "используйте числа 1-9";
                }
                else
                {
                    plan.Год = Year.Text;
                    plan.МаксКолвоСтудентов = CountStuds.Text;
                    context.ПланНабора.Add(plan);
                    context.SaveChanges();
                    StudentsCountRegular.Content = "";
                    PlanYearRegular.Content = "";
                }
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
            string specializationLeters = @"[a-zA-Z]";
            string numbers = @"[0-9]";
            string spetializationMail = @"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+";
            string spetializationPhone = @"(8 0(25|29|33|34) ([0-9]{3}( [0-9]{2}){2}))";
            string spetializationAdress = @"[a-zA-z0-9]";
            Regex Leters = new Regex(specializationLeters);
            Regex NumbersEnterprice = new Regex(numbers);
            Regex MailEntrprice = new Regex(spetializationMail);
            Regex Adress = new Regex(spetializationAdress);
            Regex PhoneReg = new Regex(spetializationPhone);
            using (var context = new kursachEntities())
            {
                Предприятия enterpr = new Предприятия();
                Договоры pacts = new Договоры();
                ПланНабора plan = new ПланНабора();
                var max = (from x in kurs.Предприятия select x.ID_предприятия).ToList().Max();
                enterpr.ID_предприятия = max + 1;
                if (!Leters.IsMatch(NameBox.Text) && (!NumbersEnterprice.IsMatch(YNPBox.Text)) && (!Adress.IsMatch(Addres.Text))
                    && (!PhoneReg.IsMatch(Phone.Text)) && (!MailEntrprice.IsMatch(Email.Text)) && (!Leters.IsMatch(ContactFaceBox.Text))
                    && (!NumbersEnterprice.IsMatch(IDEnterpricesPacts.Text)) && (!NumbersEnterprice.IsMatch(IDOfTakingOnYear.Text)))
                {
                    NameRegular.Foreground = new SolidColorBrush(Colors.Red);
                    NameRegular.Content = "буквы A-z";
                    YNPRegular.Foreground = new SolidColorBrush(Colors.Red);
                    YNPRegular.Content = "цифры 0-9";
                    AdresRegular.Foreground = new SolidColorBrush(Colors.Red);
                    AdresRegular.Content = "используйте стандартный адрес";
                    PhoneRegular.Foreground =new SolidColorBrush(Colors.Red);
                    PhoneRegular.Content = "используйте стандартный номер";
                    MailRegular.Foreground = new SolidColorBrush(Colors.Red);
                    MailRegular.Content = "логин@поддомен.домен";
                    ContactFaceRegular.Foreground = new SolidColorBrush(Colors.Red);
                    ContactFaceRegular.Content = "буквы A-z";
                    IDPactsRegular.Foreground = new SolidColorBrush(Colors.Red);
                    IDPactsRegular.Content = "Числа 0-9";
                    IDTakeOnYearRegular.Foreground = new SolidColorBrush(Colors.Red);
                    IDTakeOnYearRegular.Content = "числа 0-9";
                }
                else if (!Leters.IsMatch(NameBox.Text)){
                    NameRegular.Foreground = new SolidColorBrush(Colors.Red);
                    NameRegular.Content = "буквы A-z";
                }
                else if (!NumbersEnterprice.IsMatch(YNPBox.Text))
                {
                    YNPRegular.Foreground = new SolidColorBrush(Colors.Red);
                    YNPRegular.Content = "цифры 0-9";
                }
                else if (!Adress.IsMatch(Addres.Text))
                {
                    AdresRegular.Foreground = new SolidColorBrush(Colors.Red);
                    AdresRegular.Content = "используйте стандартный адрес";
                }
                else if (!PhoneReg.IsMatch(Phone.Text))
                {
                    PhoneRegular.Foreground = new SolidColorBrush(Colors.Red);
                    PhoneRegular.Content = "используйте стандартный номер";
                }
                else if (!MailEntrprice.IsMatch(Email.Text))
                {
                    MailRegular.Foreground = new SolidColorBrush(Colors.Red);
                    MailRegular.Content = "логин@поддомен.домен";
                }
                else if (!Leters.IsMatch(ContactFaceBox.Text))
                {
                    ContactFaceRegular.Foreground = new SolidColorBrush(Colors.Red);
                    ContactFaceRegular.Content = "буквы A-z";
                }
                else if (!NumbersEnterprice.IsMatch(IDEnterpricesPacts.Text))
                {               
                   IDPactsRegular.Foreground = new SolidColorBrush(Colors.Red);
                    IDPactsRegular.Content = "числа 0-9";
                }
                else if(pacts.IDДоговора != int.Parse(IDEnterpricesPacts.Text))
                {
                    IDPactsRegular.Foreground = new SolidColorBrush(Colors.Red);
                    IDPactsRegular.Content = "введите существующий ID";

                }
                else if (!NumbersEnterprice.IsMatch(IDOfTakingOnYear.Text))
                {
                    IDTakeOnYearRegular.Foreground = new SolidColorBrush(Colors.Red);
                    IDTakeOnYearRegular.Content = "числа 0-9";
                }
                else if(plan.IDНабораНаГод != int.Parse(IDOfTakingOnYear.Text))
                {
                    IDTakeOnYearRegular.Foreground = new SolidColorBrush(Colors.Red);
                    IDTakeOnYearRegular.Content = "введите существующий ID";

                }

                //     else if(!Leters.IsMatch(NameBox.Text)
                else
                {

                    enterpr.Название = NameBox.Text;
                    enterpr.УНП = YNPBox.Text;
                    enterpr.Адрес = Addres.Text;
                    enterpr.Телефон = Phone.Text;
                    enterpr.Эл__почта = Email.Text;
                    enterpr.Контактное_лицо = ContactFaceBox.Text;
                    enterpr.IDЗаключенныхДоговоров = int.Parse(IDEnterpricesPacts.Text);
                    enterpr.IDНабораНаГод = int.Parse(IDOfTakingOnYear.Text);
                    context.Предприятия.Add(enterpr);
                    context.SaveChanges();
                    NameRegular.Content = "";
                    YNPRegular.Content = "";
                    AdresRegular.Content = "";
                    PhoneRegular.Content = "";
                    MailRegular.Content = "";
                    ContactFaceRegular.Content = "";
                    IDTakeOnYearRegular.Content = "";
                }
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