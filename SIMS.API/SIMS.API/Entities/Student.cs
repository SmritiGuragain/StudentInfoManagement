﻿namespace SIMS.API.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender {  get; set; }
        public string ImageURL { get; set; }
        public int Sem_Id { get; set;}
        public string Email {  get; set; }  
        public int Phone {  get; set; }  

    }
}
