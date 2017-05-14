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
using System.Data.Entity;
using kursachMain.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace kursachMain.Windows 
{
    /// <summary>
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Window
    {
        kursachEntities kurs = new kursachEntities();
        //GrupsContext dbGrups;
        public Students()
        {
            InitializeComponent();
       
             //dbGrups = new GrupsContext();
            // dbGrups.Grup.Load();
           //StudentsDataGrid.ItemsSource = dbGrups.Grup.Local.ToBindingList();// устанавливаем привязку к кэшу
          //  this.Closing += Students_Closing;
        }
        //private void Students_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    dbGrups.Dispose();
        //}

        //  kursachDb db = new kursachDb();
        //Группы grups= new Группы();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// dbGrups.SaveChanges();
            //grups.НомерГруппы = nomberGr.Text;
            //grups.ФИОКуратора = Kurator.Text;
            //grups.ФИОСтаросты = Starosta.Text;
            //db.Grups.Add(grups);
            //db.SaveChanges();
            //// MessageBox.Show("saved);


        }

   

        private void Addres_TextChanged(object sender, System.Windows.Input.TextCompositionEventArgs e/*TextChangedEventArgs e*/)
        {
            //e.Handled = !IsValidInput(e.Text);
            //base.OnPreviewTextInput(e);
            //this.Text = this.Text.TrimStart('0');
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //using (var context = new kursachDb())
            //{
            //    Группы grups = new Группы();
            //    if (grups.НомерГруппы == "10")
            //    {
            //        context.Grups.Remove(grups);
            //        context.SaveChanges();
            //    }
            //}
        }

        private void SaveSpecButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new kursachEntities())
            {
                Специальности spec = new Специальности();
                spec.НазваниеСпециальности = NameSpec.Text;
                spec.НомерСпециальности = int.Parse(NomerSpec.Text);
                context.Специальности.Add(spec);
                context.SaveChanges();
            }
        }

        private void OpdateSpecButton_Click_1(object sender, RoutedEventArgs e)
        {
            var data = from x in kurs.Специальности select new {x.IDСпециальности,x.НазваниеСпециальности, x.НомерСпециальности };
            SpecDataGrid.ItemsSource = data.ToList();
        }

        private void SaveStudButton_Click(object sender, RoutedEventArgs e)
        {
        
            using (var context= new kursachEntities())
            {
                Студенты stud = new Студенты();
                stud.ФИОСтудента = StudName.Text;
                stud.IDГруппы = int.Parse(IDGrup.Text);  
                stud.НомерТелефона = PhoneStud.Text;
                stud.НомерЗачетки = NomberOfRecordBookStud.Text;
                context.Студенты.Add(stud);
                context.SaveChanges();
                MessageBox.Show("saved");
            }


        }

        private void UpdateStudButton_Click_1(object sender, RoutedEventArgs e)
        {
            //var data = from x in kurs.Группы select new { x.IDГруппы, x.НомерГруппы, x.ФИОКуратора, x.ФИОСтаросты };
            var data = from x in kurs.Студенты  select new { x.IDСтудента, x.ФИОСтудента, x.IDГруппы,x.НомерТелефона,x.НомерЗачетки };       
            StudentDataGrid.ItemsSource = data.ToList();
     

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddPact_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new kursachEntities())
            {
                Договоры pact = new Договоры();
                pact.НомерДоговора = PactNomber.Text;
                pact.ДатаЗаключения = DateOfContract.Text;
                pact.ФИОИсполнителя = ImplementerName.Text;
                pact.ДолжностьИсполнителя = ImplementPosition.Text;
                pact.НазваниеПредприятия = EnterpriceName.Text;
                pact.УченаяСтепень = academicDegree.Text;
                pact.СерияПаспорта = PasportRange.Text;
                pact.НомерПаспорта = PasportNomber.Text;
                pact.ДатаЗаключения = DateOfGiven.Text;
                pact.ОрганВыдачи = AgencyOfGive.Text;
                pact.ИдентификационныйНомер = ID_Nomber.Text;
                pact.НомерСтраховогоСвидетельства = BelayNomber.Text;
                pact.ДомашнийАдрес = HomeAdress.Text;
                pact.ТелРабочий = WorkPhoneNumber.Text;
                pact.ТелДомашний = HomePhoneNumber.Text;
                pact.МестоОсновнойРаботы = MainWorkPlace.Text;
                pact.IDСтудента = int.Parse(StudID.Text);
                pact.ДатаПроведения = DateStartPractice.Text;
                pact.КоличествоЧасов = OursCount.Text;
                pact.СтоимостьОдногоЧаса = CostOfOneOur.Text;
                pact.НомерПриказа = OrderNumber.Text;
                pact.ДатаПриказа = OrderDate.Text;
                pact.ФИООтделаКадров = FIOHumanResourcesDepartment.Text;
                pact.ФИОЗавКафедрой= FIOHeadOfPulpit.Text;
                pact.НазваниеКафедры = PulpitName.Text;
                pact.РуководительПрактики = AdministratorOfEnterprice.Text;
                
                MessageBox.Show("Добавлено");
            }
        }

        private void UpdatePact_Click(object sender, RoutedEventArgs e)
        {
         
         
            var data = from x in kurs.Договоры select new { x.IDДоговора, x.IDСтудента, x.ДатаВыдачи, x.ДатаЗаключения, x.ДатаПриказа, x.ДатаПроведения,
                x.ДолжностьИсполнителя, x.ДомашнийАдрес, x.Звание, x.КоличествоЧасов, x.МестоОсновнойРаботы, x.НазваниеКафедры, x.НазваниеПредприятия,
                x.НомерДоговора, x.НомерПаспорта, x.НомерПриказа, x.НомерСтраховогоСвидетельства, x.ОбщаяСумма, x.СтоимостьОдногоЧаса, x.ОрганВыдачи,
                x.Предприятия, x.РуководительПрактики, x.СерияПаспорта, x.Студенты, x.ТелДомашний, x.ТелРабочий, x.УченаяСтепень, x.ФИОЗавКафедрой,
                x.ФИОИсполнителя, x.ФИООтделаКадров };
            PactsDatagrid.ItemsSource = data.ToList();
        }

        private void Button_Save_Stud(object sender, RoutedEventArgs e)
        {

        
            using (var context = new kursachEntities())
            {
                Группы grups = new Группы();
                grups.НомерГруппы =int.Parse( nomberGr.Text);             
                grups.ФИОКуратора = Kurator.Text;
                grups.ФИОСтаросты = Starosta.Text;
     
                grups.IDСпециальности = int.Parse(ID_Spec.Text);
                context.Группы.Add(grups);
                context.SaveChanges();
                MessageBox.Show("Saved");
            }
        }

        private void Button_Update_Stud(object sender, RoutedEventArgs e)
        {

            var data = from x in kurs.Группы select new { x.IDГруппы, x.НомерГруппы, x.ФИОКуратора, x.ФИОСтаросты, x.IDСпециальности };
            StudentsDataGrid.ItemsSource = data.ToList();
           // SpecDataGrid.ItemsSource = data.ToList();


        }



        private void ID_stud_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ID_spec_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    


      

        private void NumberSpecTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void NameSpecTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void FIOStarostaTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void FIOKuratorTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void NumberGrTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void StudNameTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void GrupIdTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void IDSpecInStudTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PhoneNumberTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void NumberOfRecordTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PactNumberTexBox(object sender, TextChangedEventArgs e)
        {

        }

        private void CreatePactDateTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void ImplementerNameTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void ImplementPositionTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void EnterpriceNameTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PasportSerTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PasportNuberTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void AgencyOfGiveTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void IDNumberTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void BelayNumberTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void HomeAdressTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void WorkPhoneTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void HomePhoneTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void MainWorkPlaceTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void ID_StudTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void DateStartPracticeTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void OursCountTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void OrderNumberTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void FIOHumanResourcesDepartmentTextBox(object sender, TextChangedEventArgs e)
        {

        }




        private void AdministratorOfEnterpriceTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void FIOHeadOfPulpitTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PulpitNameTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void AcademicDegreeTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void SpecDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DateOfGivenTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void OrderDateTextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void PactsDatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CostOfOneOur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
