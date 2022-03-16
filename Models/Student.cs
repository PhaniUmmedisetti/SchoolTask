using school.DTO;

namespace school.Models;


public record Student
{

    public long StudentId { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTimeOffset DateOfBirth { get; set; }

    public long ClassId { get; set; }

    public string Address { get; set; }

    public Gender Gender { get; set; }

    public studentDto asDto
    {
        get
        {
            return new studentDto
            {
                StudentId = StudentId,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                ClassId = ClassId,
                Address = Address,
                Gender = Gender.ToString().ToLower(),
            };
        }
    }
}


