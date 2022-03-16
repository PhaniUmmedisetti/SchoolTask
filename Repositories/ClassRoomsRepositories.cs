using school.Models1;
using Dapper;
using System.Data;
using school.Utilities;
using school.DTO;


namespace school.Repositories;


public interface IClassRepository
{




    Task<Classroom> GetById(long StudentId);

    Task<List<Classroom>> GetList();



}


public class ClassRepository : BaseRepository, IClassRepository
{

    public ClassRepository(IConfiguration config) : base(config)

    {

    }


    public async Task<Classroom> GetById(long ClassId)
    {
        var query = $@"SELECT * FROM ""{TableNames.classroom}""
        WHERE class_id = @ClassId";

        using (var con = NewConnection)
            return await con.QuerySingleOrDefaultAsync<Classroom>(query,
            new
            {
                @ClassId = ClassId
            });
    }

    public async Task<List<Classroom>> GetList()
    {
        var query = $@"SELECT*FROM ""{TableNames.classroom}""";
        List<Classroom> res;

        using (var con = NewConnection)
        {
            res = (await con.QueryAsync<Classroom>(query)).AsList();
        }

        return res;
    }


}
