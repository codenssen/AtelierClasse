using System;


namespace AtelierClasse
{
    public class Student
    {
        // Propriétés
        private string _Name;
        public List<int> Notes;

        // Constructeur
        public Student(string name)
        {
            _Name = name;
            Notes = new List<int>();
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
            Notes.Add(note);
        }
        public string GetName()
        {
            return _Name;
        }
        public void PrintNote()
        {
            Console.WriteLine($"Note de {_Name} :");
            foreach (int note in Notes)
            {
                Console.Write($"{note} ");
            }
            Console.WriteLine();
        }
    }
}
