using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkshopTaskStatus>().HasData(
                new WorkshopTaskStatus
                {
                    Id = 1,
                    IsActive = true,
                    StatusGroupNumber = 0,
                    StatusGroupNumberOrder = 0,
                    Value = "Przyjęty"
                },
                new WorkshopTaskStatus
                {
                    Id = 2,
                    IsActive = true,
                    StatusGroupNumber = 0,
                    StatusGroupNumberOrder = 1,
                    Value = "Do odbioru"
                },
                new WorkshopTaskStatus
                {
                    Id = 3,
                    IsActive = false,
                    StatusGroupNumber = 0,
                    StatusGroupNumberOrder = 2,
                    Value = "Zrealizowany"
                },
                new WorkshopTaskStatus
                {
                    Id = 4,
                    IsActive = true,
                    StatusGroupNumber = 1,
                    StatusGroupNumberOrder = 0,
                    Value = "Anulowany - do odbioru"
                }, new WorkshopTaskStatus
                {
                    Id = 5,
                    IsActive = false,
                    StatusGroupNumber = 1,
                    StatusGroupNumberOrder = 1,
                    Value = "Anulowany - odebrany"
                }
            );
        }
    }
}
