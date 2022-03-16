using school.Modelss;
using Dapper;
using System.Data;
using school.Utilities;
using school.DTOS;

namespace school.Repositories;


public interface ITeacherRepository
{
    Task<Teacher> Create(Teacher Item);

    Task<bool> Update(Teacher Item);

    Task<bool> Delete(long Item);

    Task<Teacher> GetById(long Item);

    Task<List<Teacher>> GetList();

    Task<List<teacherDto>> GetList(long Id);



}


public class TeacherRepository : BaseRepository, ITeacherRepository
{

    public TeacherRepository(IConfiguration config) : base(config)

    {

    }

    public async Task<Teacher> Create(Teacher Item)
    {
        var query = $@"INSERT INTO ""{TableNames.teacher}"" (name gender,subject_id,mobile,date_of_birth) 
       VALUES (@Name, @Gender,@SubjectId,@Mobile, @DateOfBirth)
       RETURNING *";


        using (var con = NewConnection)
        {
            var res = await con.QuerySingleOrDefaultAsync<Teacher>(query, Item);
            return res;
        }
    }

    public async Task<bool> Delete(long TeacherId)
    {
        var query = $@"DELETE FROM ""{TableNames.teacher}"" WHERE teacher_id = @TeacherId";

        using (var con = NewConnection)
        {
            var res = await con.ExecuteAsync(query, new { TeacherId });
            return res > 0;
        }
    }

    public async Task<Teacher> GetById(long TeacherId)
    {
        var query = $@"SELECT t.*, s.subject_name FROM ""{TableNames.teacher}"" t 
        LEFT JOIN {TableNames.subject} s ON s.subject_id = t.subject_id 
        WHERE teacher_id = @TeacherId";

        using (var con = NewConnection)
            return await con.QuerySingleOrDefaultAsync<Teacher>(query,
            new
            {
                @TeacherId = TeacherId
            });
    }

    public async Task<List<Teacher>> GetList()
    {
        var query = $@"SELECT * FROM ""{TableNames.teacher}""";
        List<Teacher> res;

        using (var con = NewConnection)
        {
            res = (await con.QueryAsync<Teacher>(query)).AsList();
        }

        return res;
    }

    public async Task<List<teacherDto>> GetList(long Id)
    {
        var query = $@"SELECT t.*, subject.subject_name AS subject_name FROM {TableNames.student_teacher} st
        LEFT JOIN {TableNames.teacher} t ON t.teacher_id = st.teacher_id 
       
       LEFT JOIN {TableNames.subject} subject ON subject.subject_id = t.subject_id     
       WHERE st.student_id = @Id";


        using (var con = NewConnection)
        {

            return (await con.QueryAsync<teacherDto>(query, new { Id })).AsList();
        }
    }

    public async Task<bool> Update(Teacher Item)
    {
        var query = $@"UPDATE ""{TableNames.teacher}"" SET name = @Name,gender = @Gender, 
        subject_id=@SubjectId,mobile = @mobile,address = @Address WHERE teacher_id = @TeacherId";


        using (var con = NewConnection)
        {
            var rowCount = await con.ExecuteAsync(query, Item);

            return rowCount == 1;
        }
    }
}