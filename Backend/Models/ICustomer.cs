﻿namespace Backend.Models
{
    public interface ICustomer
    {
        string City { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}