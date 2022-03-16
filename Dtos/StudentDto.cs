

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using school.DTOS;

namespace school.DTO;

public record studentDto
{
    [JsonPropertyName("student_id")]
    public long StudentId { get; set; }


    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }


    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset DateOfBirth { get; set; }




    [JsonPropertyName("class_id")]

    public long ClassId { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("gender")]

    public string Gender { get; set; }

    [JsonPropertyName("teachers_assigned")]

    public List<teacherDto> Teacher { get; set; }

    [JsonPropertyName("subjects_assigned")]

    public List<subjectDto> Subject { get; set; }

}

public record UserCreateDto
{


    [JsonPropertyName("first_name")]
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [JsonPropertyName("gender")]
    [Required]
    [MaxLength(6)]

    public string Gender { get; set; }

    [JsonPropertyName("date_of_birth")]
    [Required]
    public DateTimeOffset DateOfBirth { get; set; }


    [JsonPropertyName("class_id")]
    [Required]
    public long ClassId { get; set; }


    [JsonPropertyName("address")]
    [Required]
    public string Address { get; set; }
}

public record UserUpdateDto
{

    [JsonPropertyName("last_name")]
    [MaxLength(50)]
    public string LastName { get; set; }



    [JsonPropertyName("address")]
    [MaxLength(255)]
    public string Address { get; set; }

}