using System;
using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.Models
{
  public class Student
  {
    public int Code {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public double grade {get; set;}
  }
}