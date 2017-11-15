using System;
namespace Main.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string RM { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        public Student(){
            
        }

        public Student(Student student){
            this.RM = student.RM; 
            this.Name = student.Name; 
            this.Mail = student.Mail;
        }

        public static Student GetStudent(){
            var student = new Student(){ 
                Id = Guid.NewGuid(),
                RM = "542621", 
                Name = "Anderson Silva", 
                Mail = "anderson@ufc.com" }; 
            return student;
        }
    }
}
