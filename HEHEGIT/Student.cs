namespace CallOfDuty
{
    public class Student
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string DutyString { get; set; } = "НЕД";
        public bool Duted => DutyString.Equals("ДЕЖ");
    }
}