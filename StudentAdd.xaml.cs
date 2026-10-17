using System.Collections.Generic;
using System.Windows;
using Constructors_Сизов.Classes;

namespace Constructors_Сизов
{
    /// <summary>
    /// Логика взаимодействия для StudentAdd.xaml
    /// </summary>
    public partial class StudentAdd : Window
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void buttonStudentAdd(object sender, RoutedEventArgs e)
        {
            AddSt
            string sourcePhoto = sourceTextBox.Text;
            string[] FIO = FIOTextBox.Text.Split(' ');

            string firstName = FIO[0];
            string lastName = FIO[1];
            string sarName = FIO[2];

            string Money = MoneyTextBox.Text;
            string Cource = courceTextBox.Text;
            bool money = false;
            if (Money == "Да" || Money == "да")
            {
                money = true;      
            }
            List<Student> allStudent2 = new List<Student>();
            //allStudent.Add(new Student("/Images/2.png", "Болотов", "Евгений", "Олегович"));

        }
        //public static List<Student> AllStudent2()
        //{
        //    List<Student> allStudent2 = new List<Student>();
        //    allStudent2.Add(new Student(sourcePhoto, firstName, lastname, sarname));
        //    return allStudent2;
        //}

    }
            
        
    
}
