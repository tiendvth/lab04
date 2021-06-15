using System;
using lab04.entity;
using lab04.SubClassForEmployee;

namespace lab04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Students()
            {
                Name = "Dang Văn Tien",
                PhoneNumber = "0981344889",
                Email = "tiendv29@gmail.com",
                Program = "C#"
            };
            Console.WriteLine(student.ToString());

            var staff = new Staff
            {
                Name = "Le thi Diep",
                PhoneNumber = "0963067437",
                Email = "diepcua37@gmail.com",
                Title = "ky su kinh te xay dung",
                Salary = 900,
                Department = "kinh te",
                DateHired = 6
            };
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"thuong cua {staff.Name} là : {staff.CalculateBonus()}");
            Console.WriteLine($"tuan nghi cua {staff.Name} là : {staff.CalculateVacation()}");


            var faculty = new Faculty()
            {
                Name = "Dang Thi mai",
                PhoneNumber = "0342809119",
                Email = "dangmai119@gmail.com",
                OfficeHours = "8h - 17h30",
                Salary = 700,
                DateHired = 8,
                Rank = 3,
                Department = "sinh vien"
            };
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"thuong cua {faculty.Name} là : {faculty.CalculateBonus()}");
            Console.WriteLine($"tuan nghi cua {faculty.Name} là : {faculty.CalculateVacation()}");
        }
    }
}