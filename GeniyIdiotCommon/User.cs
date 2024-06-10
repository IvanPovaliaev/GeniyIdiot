namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; set; }
        public int CountRightAnswers { get; set; }
        public string Diagnosis { get; set; }

        public User()
        {
            Name = "NoName";
            CountRightAnswers = 0;
            Diagnosis = "Идиот";
        }
        public User(string name)
        {
            Name = name.NullIfEmpty() ?? "NoName";
            CountRightAnswers = 0;
            Diagnosis = "Идиот";
        }
        public User(string name, int countRightAnswers, string diagnosis)
        {
            Name = name.NullIfEmpty() ?? "NoName";
            CountRightAnswers = countRightAnswers;
            Diagnosis = diagnosis;
        }
        public void IncreaseRightAnswers() => CountRightAnswers++;
        public void ResetResults()
        {
            CountRightAnswers = 0;
            Diagnosis = "Идиот";
        }
    }
}
