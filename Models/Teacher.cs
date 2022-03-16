using school.DTOS;

namespace school.Modelss;



public record Teacher
{
    public long TeacherId { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }

    public long Mobile { get; set; }

    public long SubjectId { get; set; }




    public teacherDto asDto
    {
        get
        {
            return new teacherDto
            {
                TeacherId = TeacherId,
                Name = Name,
                SubjectId = SubjectId,
                DateOfBirth = DateOfBirth,
                Mobile = Mobile,
                Gender = Gender.ToString().ToLower(),
            };
        }
    }

}

