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

namespace kursachMain.Windows
{
    /// <summary>
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Window
    {
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

            using (var context = new kursachDb())
            {
                Группы grups = new Группы();
                grups.НомерГруппы = nomberGr.Text;
                grups.ФИОКуратора = Kurator.Text;
                grups.ФИОСтаросты = Starosta.Text;
                context.Grups.Add(grups);
                context.SaveChanges();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Addres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new kursachDb())
            {
                Группы grups = new Группы();
                if (grups.НомерГруппы == "10")
                {
                    context.Grups.Remove(grups);
                    context.SaveChanges();
                }
            }
        }

        private void SaveSpecButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new kursachDb())
            {
                try
                {
                    Специальности spec = new Специальности();
                    spec.НазваниеСпециальности = NameSpec.Text;
                    spec.НомерСпециальности = NomerSpec.Text;
                    context.Spceialtes.Add(spec);
                    context.SaveChanges();
                    MessageBox.Show("saved");
                }
                catch(Exception ex)
                {
                    ex.GetBaseException();
                }
            }
            //using (var context = new kursachDb())
            //{
            //    Группы grups = new Группы();
            //    grups.НомерГруппы = nomberGr.Text;
            //    grups.ФИОКуратора = Kurator.Text;
            //    grups.ФИОСтаросты = Starosta.Text;
            //    context.Grups.Add(grups);
            //    context.SaveChanges();
            //}
        }

        private void OpdateSpecButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void SaveStudButton_Click(object sender, RoutedEventArgs e)
        {
            //using (var context = new kursachDb())
            // {
            //     Студенты stud = new Студенты();
            //     stud.ФИОСтудента = StudName.Text;


            // }

            using (var context = new kursachDb())
            {
                Группы grups = new Группы();
                grups.НомерГруппы = nomberGr.Text;
                grups.ФИОКуратора = Kurator.Text;
                grups.ФИОСтаросты = Starosta.Text;
                context.Grups.Add(grups);
                context.SaveChanges();
                MessageBox.Show("saved");
            }
        }

        private void UpdateStudButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

     
    }
}
