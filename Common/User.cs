namespace Common
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string QuestionOne { get; set; }
        public string QuestionTwo { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
       // public bool LoggedIn { get; set; }
        public int BossId { get; set; }
        public string Group { get; set; }


        public User(string username, string firstName, string lastName, string password, string questionOne, string questionTwo, string answerOne, string answerTwo)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.QuestionOne = questionOne;
            this.QuestionTwo = questionTwo;
            this.AnswerOne = answerOne;
            this.AnswerTwo = answerTwo;
            this.BossId = 0;
            this.Group = null;
        }
    }
}
