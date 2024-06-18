namespace AtelierClasse
{
    public class Student
    {
        // Propriétés
        private string _name;
        private List<int> _notes;

        // Constructeur
        public Student(string name)
        {
            _name = name;
            _notes = new List<int>();
        }

        public void SpeakTo(Student otherStudent)
        {
            Console.WriteLine($"{_name} parle à {otherStudent.GetName()}");
        }
        public void YellAt(Student otherStudent)
        {
            Console.WriteLine($"{_name} crie sur {otherStudent.GetName()}");
        }
        public void AddNote(int note)
        {
            _notes.Add(note);
        }
        public List<int> GetNote() 
        {
            return _notes; 
        }
        public string GetName()
        {
            return _name;
        }
        public void PrintNote()
        {
            Console.WriteLine($"Note de {_name} :");
            foreach (int note in _notes)
            {
                Console.Write($"{note} ");
            }
            Console.WriteLine();
        }
    }
}
