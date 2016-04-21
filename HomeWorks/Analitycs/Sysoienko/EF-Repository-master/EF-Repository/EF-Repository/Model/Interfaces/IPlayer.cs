using System;

namespace EF_Repository.Model.Interfaces
{
 public interface IPlayer
    {
     int PlayerId { get; set; }
     string Login { get; set; }
     string Password { get; set; }
     string Email { get; set; }
     bool IsValidEmail { get; set; }
     DateTime Date { get; set; }
    }
}