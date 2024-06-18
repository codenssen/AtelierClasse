namespace AtelierClasse
{
    public class Campus
    {
        //Propriété 
        public Student[] Students;

        public Campus(Student[] student)
        {
            Students = student;
        }

        public void PrintStudents()
        {
            Console.WriteLine("Liste des étudiants :");
            foreach (Student student in Students)
            {
                Console.WriteLine(student.GetName());
                Console.WriteLine("------------------------");
            }
        }

        public double NotesAverage()
        {

            if (Students.Length == 0)
            {
                return -1;
            }

            double sum = 0;
            int notesNumber = 0;

            foreach (var student in Students)
            {
                sum += student.Notes.Sum();
                notesNumber += student.Notes.Count();
            }

            return (notesNumber == 0 ? -1 : sum / notesNumber);
        }
    }
}