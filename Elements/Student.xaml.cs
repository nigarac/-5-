using System.Windows.Controls;

namespace Constructors_Сизов.Elements
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student(Classes.Student student)
        {
            InitializeComponent();

            tbFIO.Content = student.GetFIO();
            tbScholarship.Content = student.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";
            tbCourse.Content = $"Курс: {student.Course}";
        }
    }
}
