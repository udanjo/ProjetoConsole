namespace ProjectConsoleAluno.Model
{
    public record Student
    {
        public Student(string name, int note)
        {
            Name = name;
            Note = note;
        }

        public string Name { get; private set; }

        public int Note { get; private set; }
    }
}