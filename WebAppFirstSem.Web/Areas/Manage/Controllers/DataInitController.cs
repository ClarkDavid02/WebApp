using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppFirstSem.Web.Infrastructures.Domain.Data;

namespace WebAppFirstSem.Web.Areas.Manage.Controllers
{
    public class DataInitController : Controller
    {
        private readonly DefaultDbContext _context;
        public DataInitController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("manage/data-init/execute")]
        public IActionResult DataInit()
        {

            #region Students(15 Records)
            if (this._context.Students.Count() < 1)
            {

                //1
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("5fc233c2-ef24-4862-a2bc-bb7028f2f994"),
                            FirstName = "Cd",
                            LastName = "Casupanan",
                            FullName = "CD Casupanan",
                            UserName = "cdbcasupanan",
                            EmailAddress = "cdbcasupanan@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("c3eb829c-5e7d-47bc-a10b-d452bdc82093"),
                            FirstName = "Xyrille",
                            LastName = "Mamalateo",
                            FullName = "Xyrille Mamalateo",
                            UserName = "XyAnn",
                            EmailAddress = "Xyrille@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //3
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("6ed45bbc-b97e-4262-bffe-75dd47e139f2"),
                            FirstName = "Joy",
                            LastName = "Flores",
                            FullName = "Joy Flores",
                            UserName = "JoyJoy",
                            EmailAddress = "Joy@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //4
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("1d2ad294-dc92-466d-9dd5-ce9f9a3c30e6"),
                            FirstName = "Arwin",
                            LastName = "Tolentino",
                            FullName = "Arwin Tolentino",
                            UserName = "Arwin02",
                            EmailAddress = "Arwin@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("122ddb84-026f-47a4-b9d2-c480a55210de"),
                            FirstName = "Allan",
                            LastName = "Chavez",
                            FullName = "Allan Chavez",
                            UserName = "Allan",
                            EmailAddress = "Allan@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //6
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("52847597-e98e-4249-9b5b-8f51e8c61a35"),
                            FirstName = "Luisa",
                            LastName = "Reyes",
                            FullName = "Luisa Kathrina Reyes",
                            UserName = "LuisaKath",
                            EmailAddress = "Luisa@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //7
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("84a8d3e3-5254-4440-b308-102fc84db79b"),
                            FirstName = "Larich",
                            LastName = "Morales",
                            FullName = "Larich Morales",
                            UserName = "Larich01",
                            EmailAddress = "larich@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //8
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("9b46479d-c86b-4d69-a46e-fbd4aeb46235"),
                            FirstName = "Jane",
                            LastName = "Ticar",
                            FullName = "Jane Ticar",
                            UserName = "Jane02",
                            EmailAddress = "jane@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //9
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("d16306d7-57a8-4942-bbdd-c96bb6a57bee"),
                            FirstName = "Wesley",
                            LastName = "SA",
                            FullName = "Wesley SA",
                            UserName = "Wesley03",
                            EmailAddress = "Wesley@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //10
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("051e7252-b3a6-48d9-b2f8-941b6f8cee34"),
                            FirstName = "Reniel ",
                            LastName = "David",
                            FullName = "Reniel David",
                            UserName = "Reniel04",
                            EmailAddress = "Reniel@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //11
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("a3ad21f2-78d8-42d6-bf3d-420cb36ca709"),
                            FirstName = "Jhon Cedric",
                            LastName = "Romano",
                            FullName = "Jhon Cedric Romano",
                            UserName = "Jhon06",
                            EmailAddress = "Jhon@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //12
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("79029d3a-f1d5-456f-810a-58ccf09fdf1d"),
                            FirstName = "Elmo",
                            LastName = "Cahilo",
                            FullName = "Elmo Cahilo",
                            UserName = "Elmo07",
                            EmailAddress = "Elmo@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //13
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("97099897-4b5d-4123-babb-f1cc609ea33c"),
                            FirstName = "Jake Renzo",
                            LastName = "Carlos",
                            FullName = "Jake Renzo Carlos",
                            UserName = "Jake08",
                            EmailAddress = "Jake@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //14
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("7f10ff18-4ae9-44d9-937f-469ab058a04c"),
                            FirstName = "Christian",
                            LastName = "Cruz",
                            FullName = "Christian Cruz",
                            UserName = "Christian09",
                            EmailAddress = "Christian@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //15
                this._context.Students.Add(
                        new Infrastructures.Domain.Models.Student()
                        {

                            Id = Guid.Parse("712ac911-5792-4bf2-92f8-3730689e4365"),
                            FirstName = "MAMA",
                            LastName = "KO",
                            FullName = "MAMA KO",
                            UserName = "MAMA00",
                            EmailAddress = "mama@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            StudentStatus = Infrastructures.Domain.Enums.StudentStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });
            }
            #endregion

            #region Employees(15 Records)
            if (this._context.Employees.Count() < 1)
            {

                //1
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("50ab33ef-e8c4-4581-b862-759be4fd82de"),
                            FirstName = "Almira",
                            LastName = "Banzon",
                            FullName = "Almira Banzon",
                            UserName = "Almira01",
                            EmailAddress = "Almira@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("e1467a32-8ba6-4355-8a6c-af74a238efed"),
                            FirstName = "Tere ",
                            LastName = "Jimenez",
                            FullName = "Tere Jimenez",
                            UserName = "Tere02",
                            EmailAddress = "Tere@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });
                //3
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("d295605b-758d-4a5b-a3ac-89dd002fdb6b"),
                            FirstName = "Goshen",
                            LastName = "Jimenez",
                            FullName = "Goshen Jimenez",
                            UserName = "Goshen03",
                            EmailAddress = "Goshen@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //4
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("7124f436-693a-454d-ab1b-e27d3eac7fae"),
                            FirstName = "Jho",
                            LastName = "Parino",
                            FullName = "Jho Parino",
                            UserName = "Jho04",
                            EmailAddress = "Jho@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("9592a6f3-edb9-4fa9-86ef-5924912579c6"),
                            FirstName = "Rio",
                            LastName = "Balan",
                            FullName = "Rio Balan",
                            UserName = "Rio05",
                            EmailAddress = "Rio@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //6
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("7efa4c6e-b187-4cbb-aa3d-3dc536ff3ba8"),
                            FirstName = "Rona",
                            LastName = "Alagon",
                            FullName = "Rona Alagon",
                            UserName = "Rona06",
                            EmailAddress = "Rona@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //7
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("c2dfd5dc-4699-4d5b-a2d2-cfe0c7edf5e0"),
                            FirstName = "Janine",
                            LastName = "Regala",
                            FullName = "Janine Regala",
                            UserName = "Janine07",
                            EmailAddress = "Janine@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //8
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("6f9b9456-dc49-474a-ac29-45633de5c3a7"),
                            FirstName = "Shaira",
                            LastName = "Torres",
                            FullName = "Shaira Torres",
                            UserName = "Shaira08",
                            EmailAddress = "Shaira@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //9
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("70d9b514-514b-40cd-9467-b3b35f1803da"),
                            FirstName = "Cherryl",
                            LastName = "Tolentino",
                            FullName = "Cherryl Tolentino",
                            UserName = "Cherry09",
                            EmailAddress = "Cherryl@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //10
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("7fab2b8d-0cab-45bc-bd2b-571a9e154283"),
                            FirstName = "Ruffa ",
                            LastName = "Perez",
                            FullName = "Ruffa Perez",
                            UserName = "Ruffa10",
                            EmailAddress = "Ruffa@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //11
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("3fa833da-441d-4784-b598-3ed956cfb345"),
                            FirstName = "Isabel",
                            LastName = "Serrano",
                            FullName = "Isable Serrano",
                            UserName = "Isable11",
                            EmailAddress = "Isable@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //12
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("bffb4d1c-c13e-4ce6-9d45-7b2f899839c6"),
                            FirstName = "Mary Jane",
                            LastName = "Macalinao",
                            FullName = "Mary Jane Macalinao",
                            UserName = "MaryJane12",
                            EmailAddress = "Mary@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //13
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("dac9eac2-d316-4fb0-8a3b-e72f7f565e19"),
                            FirstName = "Mary Cris",
                            LastName = "Magcalas",
                            FullName = "Mary Cris Magcalas",
                            UserName = "MaryCris13",
                            EmailAddress = "Marycris@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //14
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("e703fd81-b833-442c-a4e8-09457f4f8287"),
                            FirstName = "Elmo",
                            LastName = "Cahilo",
                            FullName = "Elmo Cahilo",
                            UserName = "Elmo14",
                            EmailAddress = "Elmo@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //15
                this._context.Employees.Add(
                        new Infrastructures.Domain.Models.Employee()
                        {

                            Id = Guid.Parse("2859f220-3f73-4317-8a87-ba1b7cb97318"),
                            FirstName = "Yozef",
                            LastName = "Barcarse",
                            FullName = "Yozef Barcarse",
                            UserName = "Yozef15",
                            EmailAddress = "Yozef@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            IsPublished = true,
                            EmployeeStatus = Infrastructures.Domain.Enums.EmployeeStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });
            }
            #endregion

            #region Departments(15 Records)
            if (this._context.Departments.Count() < 1)
            {

                //1
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {
                            
                            Id = Guid.Parse("677b6be9-4e52-4823-bf04-d17758fa79fa"),
                            Name = "Finance Department",
                            Budget = 500000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("2de9b597-78dd-4f1a-a80c-efde27844d73"),
                            Name = "Registrar Department",
                            Budget = 200000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //3
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("d83c4fa2-b3d4-4b03-bff0-607709ea82f6"),
                            Name = "Marketing Department",
                            Budget = 100000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //4
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("435b07eb-0c8b-4060-8aa0-8603d633be92"),
                            Name = "Teacher Office",
                            Budget = 20000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("9bfb00c0-8f0c-4ac9-acb2-e79e00da5f68"),
                            Name = "Admin Core Office",
                            Budget = 50000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //6
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("62e2d904-b808-4ba8-8da7-40b0335da191"),
                            Name = "Admin Office",
                            Budget = 1000000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //7
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("3b8aa3d1-c883-44c5-8d35-c6661bcafe4c"),
                            Name = "Technical Department",
                            Budget = 100000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //8
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("51eeba46-7952-46b3-826d-fe7fe8e8a40e"),
                            Name = "FBS Department",
                            Budget = 100000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //9
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("3071520c-5989-4b21-95ae-a75f0f058a8e"),
                            Name = "Canteen Department",
                            Budget = 50000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //10
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("e7fd0007-91a1-428a-bce0-02812d8f1ffe"),
                            Name = "Clinic Department",
                            Budget = 20000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //11
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("e2ea51e3-a8ab-495e-af3a-8699addf8b92"),
                            Name = "I.T Department",
                            Budget = 150000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //12
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("5630fd7d-83cd-49f6-8d30-aa192b007d2b"),
                            Name = "BSCA Department",
                            Budget = 20000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //13
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("7f81c374-87e5-475e-a733-108f80799977"),
                            Name = "BSIS Department",
                            Budget = 20000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //14
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("fb365436-031d-4a5f-9201-b05470de5dac"),
                            Name = "BSCRIM Department",
                            Budget = 20000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //15
                this._context.Departments.Add(
                        new Infrastructures.Domain.Models.Department()
                        {

                            Id = Guid.Parse("c25ea0d1-3377-4e02-b9c5-89c67b21805b"),
                            Name = "BSBA Department",
                            Budget = 20000,
                            DepartmentStatus = Infrastructures.Domain.Enums.DepartmentStatus.Available,
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


            }
                #endregion
                this._context.SaveChanges();
            return Ok("Ok");
        }
    }
}