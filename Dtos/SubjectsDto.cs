using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using school.DTOS;

namespace school.DTO;

public record subjectDto
{
    [JsonPropertyName("subject_id")]
    public long SubjectId { get; set; }


    [JsonPropertyName("subject_name")]
    public string SubjectName { get; set; }

    [JsonPropertyName("Taught by")]


    public List<teacherDto> Teachers { get; set; }



}

