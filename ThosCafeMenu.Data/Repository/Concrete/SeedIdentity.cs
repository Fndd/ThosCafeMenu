using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace ThosCafeMenu.Data.Repository.Concrete
{
    public class SeedIdentity
    {
        /*      public static async Task CreateIdentityUsers(IConfiguration config, IApplicationBuilder app)
                  {
                  var serviceScope = app.ApplicationServices.CreateScope();
                  //var context = serviceScope.ServiceProvider.GetService<dbContext>();
                  var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                  var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                  var adminuserName = config["Data:AdminUser:userName"];
                  var adminemail = config["Data:AdminUser:email"];
                  var adminpassword = config["Data:AdminUser:password"];
                  var adminrole = config["Data:AdminUser:role"]; 
                  var customeruserName = config["Data:TestUser:userName"];
                  var customeremail = config["Data:TestUser:email"];
                  var customerpassword = config["Data:TestUser:password"];
                  var customerNameSurname = config["Data:TestUser:nameSurname"];
                  var customerrole = config["Data:TestUser:role"];
                  var customeraddress = config["Data:TestUser:address"];
                  var customerphone = config["Data:TestUser:phone"];
                  var customercountry = config["Data:TestUser:country"];


                  if (await userManager.FindByEmailAsync(adminemail) == null)
                  {
                      if (await roleManager.FindByNameAsync(adminrole) == null)
                      {
                          await roleManager.CreateAsync(new IdentityRole(adminrole));
                      }
                      if (await roleManager.FindByNameAsync(customerrole) == null)
                      {
                          await roleManager.CreateAsync(new IdentityRole(customerrole));
                      }

                      var user = new[]
                      {
                       new ApplicationUser()
                      {
                           UserName = adminuserName,
                           NameSurname = adminuserName,
                           Email = adminemail
                      },

                       new ApplicationUser()
                      {
                           UserName = customeruserName,
                           NameSurname = customerNameSurname,
                           Email = customeremail,
                           Address = customeraddress,
                           PhoneNumber = customerphone,
                           Country =customercountry
                      }
                      };
                      IdentityResult result = await userManager.CreateAsync(user[0], adminpassword);
                      IdentityResult resultkurumsal = await userManager.CreateAsync(user[1], customerpassword);
                      if (result.Succeeded)
                      {
                          await userManager.AddToRoleAsync(user[0], adminrole);
                      }
                      if (resultkurumsal.Succeeded)
                      {
                          await userManager.AddToRoleAsync(user[1], customerrole);
                      }

                  }
              }*/
    }
}