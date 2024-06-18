namespace AtelierClasse
{
    public class Student
    {
        // Propriétés
        private string _Name;
        private List<int> _Notes;

        // Constructeur
        public Student(string name)
        {
            _Name = name;
            _Notes = new List<int>();
        }

        public void SpeakTo(Student otherStudent)
        {
            Console.WriteLine($"{_Name} parle à {otherStudent.GetName()}");
        }
        public void YellAt(Student otherStudent)
        {
            Console.WriteLine($"{_Name} crie sur {otherStudent.GetName()}");
        }
        public void AddNote(int note)
        {
            _Notes.Add(note);
        }
        public int[] GetNote()
        {
            int[] returnedNotes = new int[_Notes.Count];
            for (int i = 0; i < _Notes.Count ; i++)
            {
                returnedNotes[i] = _Notes[i];
            }
            return returnedNotes;

        }
        public string GetName()
        {
            return _Name;
        }
        public void PrintNote()
        {
            Console.WriteLine($"Note de {_Name} :");
            foreach (int note in _Notes)
            {
                Console.Write($"{note} ");
            }
            Console.WriteLine();
        }
    }
}
