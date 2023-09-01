using CrusadeServices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrusadeServices.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context=new CrusadeServicesContext(serviceProvider.GetRequiredService<DbContextOptions<CrusadeServicesContext>>())) 
            {
                if(context.User.Any()) 
                {
                    return;//db has been seeded.
                }

                context.User.AddRange(
                    new User
                    {
                        UserName="admin",
                        Password="admin",
                        Role="admin",
                        EmployeeID=0,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
