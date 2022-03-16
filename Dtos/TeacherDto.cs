using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using school.DTO;

namespace school.DTOS;

public record teacherDto
{
    [JsonPropertyName("teacher_id")]
    public long TeacherId { get; set; }


    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("gender")]

    public string Gender { get; set; }

    [JsonPropertyName("subject_id")]

    public long SubjectId { get; set; }


    [JsonPropertyName("mobile")]

    public long Mobile { get; set; }

    [JsonPropertyName("date_of_bith")]

    public DateTimeOffset DateOfBirth { get; set; }

    [JsonPropertyName("students_assigned")]

    public List<studentDto> Student { get; set; }
}

public record TeacherCreateDto
{


    [JsonPropertyName("name")]
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }



    [JsonPropertyName("gender")]
    [Required]
    [MaxLength(6)]

    public string Gender { get; set; }



    [JsonPropertyName("subject_id")]
    [Required]

    public long SubjectId { get; set; }





    [JsonPropertyName("mobile")]

    public long Mobile { get; set; }

    [JsonPropertyName("date_of_birth")]

    public DateTimeOffset DateOfBirth { get; set; }
}

public record TeacherUpdateDto
{

    [JsonPropertyName("mobile")]

    public long Mobile { get; set; }

}