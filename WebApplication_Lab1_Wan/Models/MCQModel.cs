namespace WebApplication_Lab1_Wan.Models
{
    public class MCQModel
    {
        public string SelectedAnswer { get; set; } = "";
        public string ResultMessage { get; set; } = "";

        public void CheckAnswer()
        {
            if (!string.IsNullOrEmpty(SelectedAnswer))
            {
                ResultMessage = SelectedAnswer == "c"
                    ? "Correct! C# is a server-side programming language."
                    : "Incorrect. Try again!";
            }
        }
    }
}
