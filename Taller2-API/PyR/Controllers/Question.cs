namespace PyR.Controllers
{
    public class Question
    {
        public Question(string question, List<Dictionary<string, dynamic>> answers, string hint)
        {
            this.question = question;
            this.answers = answers;
            this.hint = hint;
        }

        public string question { get; set; }
        public List<Dictionary<string, dynamic>> answers { get; set; }
        public string hint { get; set; }
    }
}
