﻿using Identity.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Entities
{
    /// <summary>
    ///   “IdentityDbContext” sınıfına generic olarak user modelinde “ApplicationUser” sınıfının, role modelinde ise “ApplicationRole” 
    ///   sınıfının kullanılacağını belirtmiş oluyoruz. 3. parametrede ise bu yapılanmanın primary key (Id) kolonlarının
    ///   “string” tipte değerlerle tutulacağını ifade etmiş oluyoruz.
    ///   İsimlendirmelerini App olarak kısaltarak'da ilerletebilirsin.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
