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
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;


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
            try
            {
                string specialization = @"[0-9]";
                string specializationname = @"[A-za-z]";
                Regex rg = new Regex(specialization);
                Regex rg2 = new Regex(specializationname);
                using (var context = new kursachEntities())
                {
                    Специальности spec = new Специальности();
               
                    var max = (from x in kurs.Специальности select x.IDСпециальности).ToList().Max();
                    spec.IDСпециальности = max + 1;
                    if (!rg.IsMatch(NomerSpec.Text) && !rg2.IsMatch(NameSpec.Text))
                    {
                        numberspecialregular.Foreground = new SolidColorBrush(Colors.Red);
                        numberspecialregular.Content = "Неверный номер специальности";
                        namespecialregular.Foreground = new SolidColorBrush(Colors.Red);
                        namespecialregular.Content = "Неверное название специальности";
                    }
                    else if (!rg.IsMatch(NomerSpec.Text))
                    {
                        numberspecialregular.Foreground = new SolidColorBrush(Colors.Red);
                        numberspecialregular.Content = "Неверный номер специальности";
                    }
             

                    else if (!rg2.IsMatch(NameSpec.Text))
                    {
                        namespecialregular.Foreground = new SolidColorBrush(Colors.Red);
                        namespecialregular.Content = "Неверное название специальности";
                    }
                
                    else
                        {
                            spec.НазваниеСпециальности = NameSpec.Text;
                            spec.НомерСпециальности = int.Parse(NomerSpec.Text);
                            context.Специальности.Add(spec);
                        numberspecialregular.Content = " ";                  
                        namespecialregular.Content = " ";
                        context.SaveChanges();
                     
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void OpdateSpecButton_Click_1(object sender, RoutedEventArgs e)
        {
            var data = from x in kurs.Специальности select new {x.IDСпециальности,x.НазваниеСпециальности, x.НомерСпециальности };
            SpecDataGrid.ItemsSource = data.ToList();
        }

        private void SaveStudButton_Click(object sender, RoutedEventArgs e)
        {        
            try
            {
                string specialization = @"[0-9]";
                string specializationname = @"[A-za-z]";
                string spetializationphone = @"(8 0(25|29|33|34) ([0-9]{3}( [0-9]{2}){2}))";
                Regex numbers = new Regex(specialization);
                Regex leters = new Regex(specializationname);
                Regex Phone = new Regex(spetializationphone);
                using (var context = new kursachEntities())
                {
                    Студенты stud = new Студенты();
                    Группы gr = new Группы();

                    var max = (from x in kurs.Студенты select x.IDСтудента).ToList().Max();
                    stud.IDСтудента = max + 1;

                    if (!leters.IsMatch(StudName.Text) && !numbers.IsMatch(IDGrup.Text) && !Phone.IsMatch(PhoneStud.Text) && !numbers.IsMatch(NomberOfRecordBookStud.Text))
                    {
                        StudFIORegular.Foreground = new SolidColorBrush(Colors.Red);
                        StudFIORegular.Content = "используйте буквы A-z";
                        IDGrupStudRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDGrupStudRegular.Content = "используйте числа 0-9";
                        StudPhoneNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        StudPhoneNumberRegular.Content = "используйте стандартные номера";
                        StudRecordBookRegular.Foreground = new SolidColorBrush(Colors.Red);
                        StudRecordBookRegular.Content = "используйте числа 0-9";

                    }
                    else if (!leters.IsMatch(StudName.Text))
                        {
                        StudFIORegular.Foreground = new SolidColorBrush(Colors.Red);
                        StudFIORegular.Content = "используйте буквы A-z";
                         }
                    else if (!numbers.IsMatch(IDGrup.Text))
                    {
                        IDGrupStudRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDGrupStudRegular.Content = "используйте числа 0-9";
                    }
                    else if(gr.IDГруппы != int.Parse(IDGrup.Text))
                    {
                        IDGrupStudRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDGrupStudRegular.Content = "используйте существующий ID";
                    }
                    else if (!numbers.IsMatch(PhoneStud.Text))
                    {
                        StudPhoneNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        StudPhoneNumberRegular.Content = "используйте числа 0-9";
                    }
                    else if (!numbers.IsMatch(NomberOfRecordBookStud.Text))
                    {
                        StudRecordBookRegular.Foreground = new SolidColorBrush(Colors.Red);
                        StudRecordBookRegular.Content = "используйте числа 0-9";
                    }
                    else
                    {
                        stud.ФИОСтудента = StudName.Text;
                        stud.IDГруппы = int.Parse(IDGrup.Text);
                        stud.НомерТелефона = PhoneStud.Text;
                        stud.НомерЗачетки = NomberOfRecordBookStud.Text;
                        context.Студенты.Add(stud);
                        context.SaveChanges();
                        MessageBox.Show("saved");              
                        StudFIORegular.Content = "";             
                        IDGrupStudRegular.Content = "";     
                        StudPhoneNumberRegular.Content = "";       
                        StudRecordBookRegular.Content = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
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
            string specialization = @"[0-9]";
            string specializationname = @"[A-za-z]";
            string spetializationphone = @"(8 0(25|29|33|34) ([0-9]{3}( [0-9]{2}){2}))";
            string spetializationdate = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d";//Дата в формате DD/MM/YYYY:
            string spetializationPasportSer = @"[A-Z]{2}";
            string spetializationPasportRange = @"[0-9]{6}";
            string spetializationAdress = @"[a-zA-z0-9]";
            Regex numbers = new Regex(specialization);
            Regex leters = new Regex(specializationname);
            Regex Phone = new Regex(spetializationphone);
            Regex Date = new Regex(spetializationdate);
            Regex PasportSer = new Regex(spetializationPasportSer);
            Regex PasportNumbers = new Regex(spetializationPasportRange);
            Regex Adress = new Regex(spetializationAdress);
            try
            {
                using (var context = new kursachEntities())
                {
                    Договоры pact = new Договоры();
                    Студенты stud = new Студенты();
                    var max = (from x in kurs.Договоры select x.IDДоговора).ToList().Max();
                    pact.IDДоговора = max + 1;


                    if (!numbers.IsMatch(PactNomber.Text))
                    {
                        PactNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PactNumberRegular.Content = "числа 0-9";
                    }
                    else if (!Date.IsMatch(DateOfContract.Text))
                    {
                        CreateDatePactRegular.Foreground = new SolidColorBrush(Colors.Red);
                        CreateDatePactRegular.Content = "DD/MM/YYYY";
                    }
                    else if (!leters.IsMatch(ImplementerName.Text))
                    {
                        FIOOfExecutorRegular.Foreground = new SolidColorBrush(Colors.Red);
                        FIOOfExecutorRegular.Content = "буквы A-z";                 
                    }
                    else if (!leters.IsMatch(ImplementPosition.Text))
                    {
                        ExecutorRankRegular.Foreground = new SolidColorBrush(Colors.Red);
                        ExecutorRankRegular.Content = "буквы A-Z";
                    }
                    else if (!leters.IsMatch(EnterpriceName.Text))
                    {
                        EnterpriceNameregular.Foreground = new SolidColorBrush(Colors.Red);
                        EnterpriceNameregular.Content = "буквы A-Z";
                    }
                    else if (!leters.IsMatch(academicDegree.Text))
                    {
                        AcademcDegreeRegular.Foreground = new SolidColorBrush(Colors.Red);
                        AcademcDegreeRegular.Content = "буквы A-z";
                    }
                    else if (!leters.IsMatch(Rank.Text))
                    {
                        RankRegular.Foreground = new SolidColorBrush(Colors.Red);
                        RankRegular.Content = "буквы A-z";
                    }
                    else if (!PasportSer.IsMatch(PasportRange.Text))
                    {
                        PasportSerRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PasportSerRegular.Content = "2 буквы A-Z";
                    }
                    else if (!PasportNumbers.IsMatch(PasportNomber.Text))
                    {
                        PasportNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PasportNumberRegular.Content = "цифры 0-9";
                    }
                    else if (!Date.IsMatch(DateOfGiven.Text))
                    {
                        DateOfTakenPactRegular.Foreground = new SolidColorBrush(Colors.Red);
                        DateOfTakenPactRegular.Content = "DD/MM/YYYY";
                    }
                    else if (!leters.IsMatch(AgencyOfGive.Text))
                    {
                        AgencyOfGivenRegular.Foreground = new SolidColorBrush(Colors.Red);
                        AgencyOfGivenRegular.Content = "Буквы A-z";
                    }
                    else if (!numbers.IsMatch(ID_Nomber.Text))
                    {
                        ID_NumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        ID_NumberRegular.Content = "числа 0-9";
                    }
                    else if (!numbers.IsMatch(BelayNomber.Text))
                    {
                        belayNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        belayNumberRegular.Content = "цифры 0-9";
                    }
                    else if (!Adress.IsMatch(HomeAdress.Text))
                    {
                        HomeAdressRegular.Foreground = new SolidColorBrush(Colors.Red);
                        HomeAdressRegular.Content = "буквы A-z";
                    }
                    else if (!Phone.IsMatch(WorkPhoneNumber.Text))
                    {
                        WorkPhoneRegular.Foreground = new SolidColorBrush(Colors.Red);
                        WorkPhoneRegular.Content = "неверный формат номера";
                    }
                    else if (!Phone.IsMatch(HomePhoneNumber.Text))
                    {
                        HomePhoneRegular.Foreground = new SolidColorBrush(Colors.Red);
                        HomePhoneRegular.Content = "неверный формат номера";
                    }
                    else if (!leters.IsMatch(MainWorkPlace.Text))
                    {
                        MainWorkPlaceRegular.Foreground = new SolidColorBrush(Colors.Red);
                        MainWorkPlaceRegular.Content = "буквы A-z";
                    }
                    else if (!numbers.IsMatch(StudID.Text))
                    {
                        IDStudRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDStudRegular.Content = "числа 0-9";
                    }
                    else if (stud.IDСтудента!=int.Parse(StudID.Text))
                    {
                        IDStudRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDStudRegular.Content = "неверный ID";
                    }
                    else if (!Date.IsMatch(DateStartPractice.Text))
                    {
                        DatePracticeRegular.Foreground = new SolidColorBrush(Colors.Red);
                        DatePracticeRegular.Content = "неверный формат даты";
                    }
                    else if (!numbers.IsMatch(OursCount.Text))
                    {
                        HoursCountRegular.Foreground = new SolidColorBrush(Colors.Red);
                        HoursCountRegular.Content = "числа 0-9";
                    }
                    else if (!numbers.IsMatch(CostOfOneOur.Text))
                    {
                        CostOfOneOurRegular.Foreground = new SolidColorBrush(Colors.Red);
                        CostOfOneOurRegular.Content="числа 0-9";
                    }
                    else if (!numbers.IsMatch(TotalCost.Text))
                    {
                        OurCountRegular.Foreground = new SolidColorBrush(Colors.Red);
                        OurCountRegular.Content = "числа 0-9";                
                    }
                    else if (!numbers.IsMatch(OrderNumber.Text))
                    {
                        PactNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PactNumberRegular.Content = "числа 0-9";
                    }
                    else if (!numbers.IsMatch(OrderNumber.Text))
                    {
                        PactNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PactNumberRegular.Content = "числа 0-9";
                    }
                    else if (!Date.IsMatch(OrderDate.Text))
                    {
                        PactDateRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PactDateRegular.Content = "DD/MM/YYYY";
                    }
                    else if (!leters.IsMatch(FIOHumanResourcesDepartment.Text))
                    {
                        FIOHumanResDepartmentRegular.Foreground = new SolidColorBrush(Colors.Red);
                        FIOHumanResDepartmentRegular.Content = "Буквы A-z";
                    }
                    else if (!leters.IsMatch(FIOHeadOfPulpit.Text))
                    {
                        FIOZavKafedroyRegular.Foreground = new SolidColorBrush(Colors.Red);
                        FIOZavKafedroyRegular.Content = "Буквы A-z";
                    }
                    else if (!leters.IsMatch(PulpitName.Text))
                    {
                        PulpitNameRegular.Foreground = new SolidColorBrush(Colors.Red);
                        PulpitNameRegular.Content = "Буквы A-z";
                    }
                    else if (!leters.IsMatch(AdministratorOfEnterprice.Text))
                    {
                        EnterpriceLeaderRegular.Foreground = new SolidColorBrush(Colors.Red);
                        EnterpriceLeaderRegular.Content = "Буквы A-z";
                    }
                   

                    else
                    {
                        
                        pact.НомерДоговора = PactNomber.Text;
                        pact.ДатаЗаключения = DateOfContract.Text;
                        pact.ФИОИсполнителя = ImplementerName.Text;
                        pact.ДолжностьИсполнителя = ImplementPosition.Text;
                        pact.НазваниеПредприятия = EnterpriceName.Text;
                        pact.УченаяСтепень = academicDegree.Text;
                        pact.Звание = Rank.Text;
                        pact.СерияПаспорта = PasportRange.Text;
                        pact.НомерПаспорта = PasportNomber.Text;
                        pact.ДатаВыдачи = DateOfGiven.Text;
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
                        pact.ФИОЗавКафедрой = FIOHeadOfPulpit.Text;
                        pact.НазваниеКафедры = PulpitName.Text;
                        pact.РуководительПрактики = AdministratorOfEnterprice.Text;
                        pact.ОбщаяСумма = TotalCost.Text;

                        context.Договоры.Add(pact);
                        context.SaveChanges();
                        MessageBox.Show("Добавлено");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UpdatePact_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = from x in kurs.Договоры
                           select new
                           {
                               x.IDДоговора,
                               x.IDСтудента,
                               x.ДатаВыдачи,
                               x.ДатаЗаключения,
                               x.ДатаПриказа,
                               x.ДатаПроведения,
                               x.ДолжностьИсполнителя,
                               x.ДомашнийАдрес,
                               x.Звание,
                               x.КоличествоЧасов,
                               x.МестоОсновнойРаботы,
                               x.НазваниеКафедры,
                               x.НазваниеПредприятия,
                               x.НомерДоговора,
                               x.НомерПаспорта,
                               x.НомерПриказа,
                               x.НомерСтраховогоСвидетельства,
                               x.ОбщаяСумма,
                               x.СтоимостьОдногоЧаса,
                               x.ОрганВыдачи,
                               x.Предприятия,
                               x.РуководительПрактики,
                               x.СерияПаспорта,
                             //  x.Студенты,
                               x.ТелДомашний,
                               x.ТелРабочий,
                               x.УченаяСтепень,
                               x.ФИОЗавКафедрой,
                               x.ФИОИсполнителя,
                               x.ФИООтделаКадров
                           };
                PactsDatagrid.ItemsSource = data.ToList();
            }
            catch(SqlException ex)
            {
                ex.GetBaseException();
            }
        }

        private void Button_Save_Stud(object sender, RoutedEventArgs e)
        {


            using (var context = new kursachEntities())
            {
                Специальности spec = new Специальности();
                Группы grups = new Группы();
                string specialization = @"[0-9]";
                string specializationname = @"[A-Za-z]";

                Regex numbers = new Regex(specialization);
                Regex leters = new Regex(specializationname);
                try {
                    if (!numbers.IsMatch(nomberGr.Text) && !leters.IsMatch(Kurator.Text) && !leters.IsMatch(Starosta.Text) && !numbers.IsMatch(ID_Spec.Text))
                    {
                        GrupNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        GrupNumberRegular.Content = "используйте числа 0-9";
                        KuratorFIORegular.Foreground = new SolidColorBrush(Colors.Red);
                        KuratorFIORegular.Content = "используйте буквы A-z";
                        StarostaFIORegular.Foreground = new SolidColorBrush(Colors.Red);
                        StarostaFIORegular.Content = "используйте буквы A-z";
                        IDSpecialRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDSpecialRegular.Content = "используйте числа 0-9";

                    }
                    else if (!numbers.IsMatch(nomberGr.Text))
                    {
                        GrupNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        GrupNumberRegular.Content = "используйте числа 0-9";
                    }
                    else if (grups.НомерГруппы == int.Parse(nomberGr.Text))
                    {
                        GrupNumberRegular.Foreground = new SolidColorBrush(Colors.Red);
                        GrupNumberRegular.Content = "такой номер группы уже существует";
                    }
                    else if (!leters.IsMatch(Kurator.Text))
                    {
                        KuratorFIORegular.Foreground = new SolidColorBrush(Colors.Red);
                        KuratorFIORegular.Content = "используйте буквы A-z";
                    }
                    else if (!leters.IsMatch(Starosta.Text))
                    {
                        StarostaFIORegular.Foreground = new SolidColorBrush(Colors.Red);
                        StarostaFIORegular.Content = "используйте буквы A-z";
                    }
                    else if (!numbers.IsMatch(ID_Spec.Text))
                    {
                        IDSpecialRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDSpecialRegular.Content = "используйте числа 0-9";
                    }
                    else if ((spec.IDСпециальности != int.Parse(ID_Spec.Text)))
                    {
                        IDSpecialRegular.Foreground = new SolidColorBrush(Colors.Red);
                        IDSpecialRegular.Content = "используйте существующий ID";
                    }
                    else
                    {
                        
                        grups.НомерГруппы = int.Parse(nomberGr.Text);
                        grups.ФИОКуратора = Kurator.Text;
                        grups.ФИОСтаросты = Starosta.Text;

                        grups.IDСпециальности = int.Parse(ID_Spec.Text);
                        context.Группы.Add(grups);
                        context.SaveChanges();
                        MessageBox.Show("Saved");
                        IDSpecialRegular.Content = "";
                        StarostaFIORegular.Content = "";
                        KuratorFIORegular.Content = "";
                        GrupNumberRegular.Content = "";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

        }

        private void Button_Update_Stud(object sender, RoutedEventArgs e)
        {
            var data = from x in kurs.Группы select new { x.IDГруппы, x.НомерГруппы, x.ФИОКуратора, x.ФИОСтаросты, x.IDСпециальности };
            StudentsDataGrid.ItemsSource = data.ToList();
            //SpecDataGrid.ItemsSource = data.ToList();
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

        private void TotalCost_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DeleteSpec_Click(object sender, RoutedEventArgs e)
        {
            if (SpecDataGrid.SelectedIndex != -1)
            {

                using (var context = new kursachEntities())
                {
                    //  Специальности gr = new Специальности();
                    //  gr.IDСпециальности = int.Parse(DeleteSpec.Text);
                    //var max = (from x in kurs.Договоры select x.IDДоговора).ToList().Max();
                    //pacts.IDДоговора = max + 1;
                    // var UserID = (SpecDataGrid.SelectedItem as Специальности).IDСпециальности;
                   // var GrupsID = (from x in context.Специальности select x.IDСпециальности);
                    //var deleteSpec = (from x in context.Специальности where x.IDСпециальности == GrupsID select x.IDСпециальности);
                    // var deletedSpec = (from i in context.Специальности where GrupsID == i.IDСпециальности select i).Single();
                    //  context.Специальности.Attach(deletedSpec);
                   // context.Специальности.Remove(deletedSpec);
                   DataRowView SelectedRow =(DataRowView) SpecDataGrid.SelectedItem;
                    int SpecID = (int)SelectedRow["IDСпециальности"];
                    var deleteSpec = (from i in context.Специальности where SpecID == i.IDСпециальности select i).Single();
                    context.Специальности.Remove(deleteSpec);
                    context.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("pick id in grid");

            }
            
        }


        
        private void deleleteGrup_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StudentsDataGrid.SelectedIndex != -1)
                {
                    using (var context = new kursachEntities())
                    {
                        int UserID = (StudentsDataGrid.SelectedItem as Группы).IDГруппы;
                        var deletedUser1 = (from i in context.Группы where UserID == i.IDГруппы select i).Single();
                        context.Группы.Remove(deletedUser1);
                        context.SaveChanges();
                    }

                }
                else
                {

                    MessageBox.Show("Error Select ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

       
    }
}
