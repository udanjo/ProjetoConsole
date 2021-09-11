namespace ProjectConsoleAluno.Model
{
    public record Aluno
    {
        public Aluno(string name, double note)
        {
            Name = name;
            Note = note;
        }

        public string Name { get; private set; }

        public double Note { get; private set; }
    }
}