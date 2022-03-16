using school.DTO;

namespace school.Models1;


public record Classroom
{

    public long ClassId { get; set; }

    public int Benches { get; set; }

    public int Tables { get; set; }

    public classDto asDto
    {
        get
        {
            return new classDto
            {
                ClassId = ClassId,
                Benches = Benches.ToString(),
                Tables = Tables.ToString(),

            };
        }
    }



}