using Constructors_Сизов.Classes;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Constructors_Сизов
{
    /// <summary>
    /// Логика взаимодействия для StudentAdd.xaml
    /// </summary>
    public partial class StudentAdd : Window
    {
        private List<Student> currentStudents;

        public StudentAdd(List<Student> students)
        {
            InitializeComponent();
            currentStudents = students; 
        }
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void buttonStudentAdd(object sender, RoutedEventArgs e)
        {
            
            string sourcePhoto = sourceTextBox.Text;
            string[] FIO = FIOTextBox.Text.Split(' ');
            if (FIO.Length < 3)
            {
                MessageBox.Show("Введите ФИО полностью (Фамилия Имя Отчество)");
                return;
            }
            string firstName = FIO[0];
            string lastName = FIO[1];
            string sarName = FIO[2];

            string Money = MoneyTextBox.Text;
            int courseValue;
            if (!int.TryParse(courceTextBox.Text, out courseValue))
            {
                MessageBox.Show("Курс должен быть числом (например, 1, 2, 3, 4)!");
                return;
            }
            bool money = false;
            if (Money == "Да" || Money == "да")
            {
                money = true;      
            }
            List<Student> allStudent2 = new List<Student>();
            Student newStudent = new Student(sourcePhoto, firstName, lastName, sarName, money, courseValue);
            currentStudents.Add(newStudent);
            this.Close();
        }


    }
            
        
    
}
