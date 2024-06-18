namespace AtelierClasse
{
    public class Campus
    {
        //Propriété 
        private Student[] _Students;

        public Campus(Student[] student)
        {
            _Students = student;
        }

        public void PrintStudents()
        {
            Console.WriteLine("Liste des étudiants :");
            foreach (Student student in _Students)
            {
                Console.WriteLine(student.GetName());
                Console.WriteLine("------------------------");
            }
        }

        public double NotesAverage()
        {

            if (_Students.Length == 0)
            {
                return -1;
            }

            double sum = 0;
            int notesNumber = 0;

            foreach (var student in _Students)
            {
                int[] studentNotes = student.GetNote();
                sum += studentNotes.Sum();
                notesNumber += studentNotes.Count();
            }

            return (notesNumber == 0 ? -1 : sum / notesNumber);
        }
    }
}