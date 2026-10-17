using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            UserPhoto.Source = new BitmapImage(new Uri(student.PhotoSource, UriKind.Relative));
            tbFIO.Content = student.GetFIO();
            tbScholarship.Content = student.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";
            tbCourse.Content = $"Курс: {student.Course}";
        }
    }
}
