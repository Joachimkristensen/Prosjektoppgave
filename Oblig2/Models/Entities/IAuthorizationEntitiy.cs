﻿namespace Oblig2.Models.Entities
{
    public interface IAuthorizationEntity
    {
        ApplicationUser Owner { get; set; }
    }
}