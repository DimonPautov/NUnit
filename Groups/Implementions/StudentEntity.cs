namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public int Grade { get; set; }

    public void Promote()
    {
        Grade++;
    }
}