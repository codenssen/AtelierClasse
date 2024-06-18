namespace AtelierClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Aurelien");
            Student student2 = new Student("Robert");
            student1.AddNote(13);
            student1.AddNote(12);
            student1.AddNote(19);
            student1.PrintNote();
            student2.AddNote(11);
            student1.SpeakTo(student2);
            student2.YellAt(student1);
 

            //Campus
            Student[] students = { student1, student2 };
            Campus campus = new Campus(students);
            campus.PrintStudents();
            Console.WriteLine($"Moyenne du campus : {campus.NotesAverage()}");
        }
    }
}
