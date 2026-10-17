namespace Constructors_Сизов.Classes
{
    public class Student
    {
        public string PhotoSource { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public bool Scholarship = false;
        public int Course = 4;

        public Student(string photoSource, string firstname, string lastname, string surname)
        {
            this.PhotoSource = photoSource;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Surname = surname;
        }

        public Student(string photoSource, string firstname, string lastname, string surname, bool scholarship) : this(photoSource,firstname, lastname, surname)
        {
            this.Scholarship = scholarship;

        }

        public Student(string photoSource, string firstname, string lastname, string surname, bool scholarship, int course) : this(photoSource, firstname, lastname, surname, scholarship)
        {
            Course = course;
        }


        public string GetFIO()
        {
            return $"{Lastname}{Firstname}{Surname}";
        }
    }
}
