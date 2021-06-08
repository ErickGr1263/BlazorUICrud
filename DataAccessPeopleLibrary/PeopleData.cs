using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "select * from dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task <PersonModel> GetPerson(int id)
        {
            string sql = @"select * from dbo.People where Id = @Id;";

            return _db.LoadSingle<PersonModel, dynamic>(sql, new { Id = id });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
                            values (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, person);
        }

        public Task UpdatePerson(PersonModel person)
        {
            string sql = @"update dbo.People set FirstName = @FirstName, LastName = @LastName, EmailAddress =@EmailAddress
                            where Id = @Id;";

            return _db.SaveData(sql, person);
        }
        public Task DeletePerson(PersonModel person)
        {
            string sql = @"delete from dbo.People where Id = @Id;";

            return _db.SaveData(sql, person);
        }
    }
}
