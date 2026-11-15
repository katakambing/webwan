namespace WebApplication_Lab1_Wan.Models
{
    public class GradeModel
    {
        public string Name { get; set; } = "";
        public double Test { get; set; }
        public double Assignment { get; set; }
        public double Project { get; set; }
        public double FinalExam { get; set; }
        public double? OverallMark { get; set; }
        public string Grade { get; set; } = "";
    }
}
