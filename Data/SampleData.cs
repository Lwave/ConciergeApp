using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using ConciergeApp.Models;
using System.Collections.Generic;

namespace ConciergeApp.Data
{
    public class SampleData
    {
        public async static Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<ApplicationDbContext>();
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            // Ensure db
            await db.Database.EnsureCreatedAsync();

            // Ensure Stephen (IsAdmin)
            var stephen = await userManager.FindByNameAsync("Stephen.Walther@CoderCamps.com");
            if (stephen == null)
            {
                // create user
                stephen = new ApplicationUser
                {
                    UserName = "Stephen.Walther@CoderCamps.com",
                    Email = "Stephen.Walther@CoderCamps.com",
                    FirstName = "Stephen",
                    LastName = "Walther",
                    Image = "http://i50.photobucket.com/albums/f342/rjupio/FashionModelMaleBrunette_zpso8iiks8t.jpg",
                    Type = "Admin",
                    Preference = new Preference
                    {
                        TypeofBusiness = "Restaurant",
                        Price = 10.00m,
                        FoodType = "Pizza"
                    }
                    
                };
                await userManager.CreateAsync(stephen, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(stephen, new Claim("IsAdmin", "true"));
            }

            // Ensure Mike (not IsAdmin)
            var mike = await userManager.FindByNameAsync("Mike@CoderCamps.com");
            if (mike == null)
            {
                // create user
                mike = new ApplicationUser
                {
                    UserName = "Mike@CoderCamps.com",
                    Email = "Mike@CoderCamps.com",
                    FirstName = "Mike",
                    LastName = "McCoy",
                    Image = "http://www.bordeaux-tourism.co.uk/var/ezwebin_site/storage/images/media/images/regards-bordelais/jean-poutge/profil-jean/12599-2-fre-FR/Profil-Jean_format_360x360.jpg",
                    Type = "User",
                    Preference = new Preference
                    {
                        TypeofBusiness = "Restaurant",
                        Price = 20.00m,
                        FoodType = "Seafood"
                    }
                    
                };
                await userManager.CreateAsync(mike, "Secret123!");
            }
            var josie = await userManager.FindByNameAsync("JosieA@CoderCamps.com");
            if (josie == null)
            {
                // create user
                josie = new ApplicationUser
                {
                    UserName = "JosieA@CoderCamps.com",
                    Email = "JosieA@CoderCamps.com",
                    FirstName = "Josie",
                    LastName = "Alcanza",
                    Image = "http://i50.photobucket.com/albums/f342/rjupio/FaceModelFemaleAsian_zpsqhqswerq.jpg",
                    Type = "User",
                    Preference = new Preference
                    {
                        TypeofBusiness = "Restaurant",
                        Price = 30.00m,
                        FoodType = "Chinese"
                    }
                    
                };
                await userManager.CreateAsync(josie, "Secret123!");
            }
            var randy = await userManager.FindByNameAsync("RandyJ@CoderCamps.com");
            if (randy == null)
            {
                // create user
                randy = new ApplicationUser
                {
                    UserName = "RandyJ@CoderCamps.com",
                    Email = "RandyJ@CoderCamps.com",
                    FirstName = "Randy",
                    LastName = "Jupio",
                    Image = "http://i50.photobucket.com/albums/f342/rjupio/prof%20pic_zpsmno52ypq.jpg",
                    Type = "User",
                    Preference = new Preference
                    {
                        TypeofBusiness = "Restaurant",
                        Price = 5.00m,
                        FoodType = "French"
                    }
                    
                };
                await userManager.CreateAsync(randy, "Secret123!");
            }
            var lesley = await userManager.FindByNameAsync("lesleywayne@codercamps.com");
            if (lesley == null)
            {
                //create user 
                lesley = new ApplicationUser
                {
                    UserName = "lesleywayne@codercamps.com",
                    Email = "lesleywayne@codercamps.com",
                    FirstName = "Lesley",
                    LastName = "Wayne",
                    Image = "",
                    Type = "User",
                    Preference = new Preference
                    {
                        TypeofBusiness = "Restaurant",
                        Price = 5.00m,
                        FoodType = "Pizza"
                    }
                };
                await userManager.CreateAsync(lesley, "Secret123!");
            }
            var sarah = await userManager.FindByNameAsync("SarahK@CoderCamps.com");
            if (sarah == null)
            {
                // create user
                sarah = new ApplicationUser
                {
                    UserName = "SarahK@CoderCamps.com",
                    Email = "SarahK@CoderCamps.com",
                    FirstName = "Sarah",
                    LastName = "Kablowski",
                    Image = "http://i50.photobucket.com/albums/f342/rjupio/Lady_Bunny_zpsenf4hlw7.jpg",
                    Type = "User",
                    Preference = new Preference
                    {
                        TypeofBusiness = "Restaurant",
                        Price = 50.00m,
                        FoodType = "Steakhouse"
                    }

                };
                await userManager.CreateAsync(sarah, "Secret123!");
            }
        }

    }
}
