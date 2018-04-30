using System.Xml.Linq;
using UniversityCourseResultManagementSystem.Models;

namespace UniversityCourseResultManagementSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityCourseResultManagementSystem.Models.ProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniversityCourseResultManagementSystem.Models.ProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //context.Days.AddOrUpdate(
            //    new Day { Name = "Saturday" },
            //    new Day { Name = "Sunday" },
            //    new Day { Name = "Monday" },
            //    new Day { Name = "Tuesday" },
            //    new Day { Name = "Wednesday" },
            //    new Day { Name = "Thursday" },
            //    new Day { Name = "Friday" }
            //    );
            //context.Semesters.AddOrUpdate(
            //    new Semester { SemesterName = "1st Semester" },
            //    new Semester { SemesterName = "2nd Semester" },
            //    new Semester { SemesterName = "3rd Semester" },
            //    new Semester { SemesterName = "4th Semester" },
            //    new Semester { SemesterName = "5th Semester" },
            //    new Semester { SemesterName = "6th Semester" },
            //    new Semester { SemesterName = "7th Semester" },
            //    new Semester { SemesterName = "8th Semester" }
            //    );

            ////context.Departments.AddOrUpdate(
            ////    new Department { DeptCode = "CSE", DeptName = "Computer Science & Engineering" },
            ////    new Department { DeptCode = "EEE", DeptName = "Electrical & Electronic Engineering" },
            ////    new Department { DeptCode = "ETE", DeptName = "Electronic & Telecommunication Engineering" },
            ////    new Department { DeptCode = "TE", DeptName = "Department Of Textile Engineering" },
            ////    new Department { DeptCode = "BBA", DeptName = "Bachelor of Business Administration" }
            ////    );
            //context.Designations.AddOrUpdate(
            //    new Designation { DesignationName = "Lecturer" },
            //    new Designation { DesignationName = "Sr. Lacturer" },
            //    new Designation { DesignationName = "Professor" },
            //    new Designation { DesignationName = "Assiciate Professor" },
            //    new Designation { DesignationName = "Assaistant Professor" }

            //    );
            //context.Rooms.AddOrUpdate(
            //    new Room { Name = "101" },
            //    new Room { Name = "103" },
            //    new Room { Name = "104" },
            //    new Room { Name = "105" },
            //    new Room { Name = "203" },
            //    new Room { Name = "204" },
            //    new Room { Name = "303-L" },
            //    new Room { Name = "304-L" }

            //    );
            //context.Grades.AddOrUpdate(
            //    new Grade { GradeName = "A+" },
            //    new Grade { GradeName = "A" },
            //    new Grade { GradeName = "A-" },
            //    new Grade { GradeName = "B+" },
            //    new Grade { GradeName = "B" },
            //    new Grade { GradeName = "B-" },
            //    new Grade { GradeName = "C+" },
            //    new Grade { GradeName = "C" },
            //    new Grade { GradeName = "C-" },
            //    new Grade { GradeName = "D+" },
            //    new Grade { GradeName = "D" },
            //    new Grade { GradeName = "D" },
            //    new Grade { GradeName = "F" }
            //    );

        }
    }
}
