using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using school.DTOS;

namespace school.DTO;

public record classDto
{
    [JsonPropertyName("class_id")]
    public long ClassId { get; set; }


    [JsonPropertyName("benches")]
    public string Benches { get; set; }

    [JsonPropertyName("tables")]


    public string Tables { get; set; }



}