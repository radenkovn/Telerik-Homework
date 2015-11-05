namespace StudentSystem.Services.Controllers
{
    using StudentSystem.Models;
    using System.Web.Http;

    public class StudentsController : ApiController
    {
        public Student Get()
        {
            return new Student
            {
                FirstName="Pesho",
                LastName="Ivanov"
            };
        }
    }
}