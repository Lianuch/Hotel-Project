using Hotel.Data.Enum;
using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;
using Hotel.Models;
using Hotel.Data;

namespace RunGroopWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Rooms.Any())
                {
                    context.Rooms.AddRange(new List<Room>()
                    {
                        new Room()
                        {
                            Title = "Junior Suite",
                            Image = "https://i.imgur.com/RZiPATw.jpg",
                            Description = "A spacious bedroom and living room will give you a feeling of lightness and home comfort. ",
                            RoomCategory = RoomCategory.JuniorSuite,
                            InfoUser = new InfoDescription()
                            {

                                Floor = "The second",
                                Price = "210$"
                            }
                         },
                        new Room()
                        {
                            Title = "Deluxe room",
                            Image = "https://i.imgur.com/biXoxqT.jpg",
                            Description = "A deluxe room is best suited for families with children,because everyone will have their own space",
                            RoomCategory = RoomCategory.DeluxeRoom,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "The third",
                                Price = "270$"
                            }
                        },
                        new Room()
                        {
                            Title = "Presidental Apartaments",
                            Image = "https://i.imgur.com/6cBbE90.jpg",
                            Description = "Presidential apartments - the best and the most spacious room Egoista Hotel.",
                            RoomCategory = RoomCategory.PresidentalApartaments,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "The fourth",
                                Price = "1750$"
                            }
                        },
                        new Room()
                        {
                            Title = "Standard with a large bed",
                            Image = "https://i.imgur.com/gyo9GSf.jpg",
                            Description = "Rest and continue conquering the world. The standard room ideal for business trips and short trips.",
                            RoomCategory = RoomCategory.StandardLargeBed,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "The first",
                                Price = "159$"
                            }
                        },
                         new Room()
                        {
                            Title = "Standard with two beds",
                            Image = "https://i.imgur.com/oNe4gZt.jpg",
                            Description = "Traveling with a friend or colleague?Standard room with two beds definitely for you",
                            RoomCategory = RoomCategory.StandardLargeDouble,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "The second",
                                Price= "189$"
                            }
                        },
                         new Room()
                         {
                             Title = "Superior room",
                            Image = "https://i.imgur.com/i4lfomJ.jpg",
                            Description = "Superior room is ideal for both leisure and business trips.",
                            RoomCategory = RoomCategory.SuperiorRoom,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "The first",
                                Price = "169$"
                            }
                         }

                    });
                    context.SaveChanges();
                }
                //Restaurant
                if (!context.Restaurants.Any())
                {
                    context.Restaurants.AddRange(new List<Restaurant>()
                    {
                        new Restaurant()
                        {
                            Title = "Pizzas",
                            Image = "https://i.imgur.com/TQVS9yG.jpg",
                            Description = "Classic Italian pizza is a sunny symphony of flavor. ",
                            RestaurantCategory = RestaurantCategory.Pizzas,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "Pizzas",
                                Price = "From 10,50$"
                            }
                        },
                        new Restaurant()
                        {
                            Title = "Salads",
                            Image = "https://i.imgur.com/aFBDPvl.jpg",
                            Description = "The salad is a colorful symphony of fresh flavors. Green leafy bases, a selection of tender vegetables, and aromatic seasonings.",
                            RestaurantCategory = RestaurantCategory.Salads,
                            
                            InfoUser = new InfoDescription()
                            {
                                Floor = "Salads",
                                Price = "From 8,75$"
                            }
                        },
                         new Restaurant()
                        {
                            Title = "Meat",
                            Image = "https://i.imgur.com/B2mya7W.jpg",
                            Description = "Delicious and tender meat with a perfect flavor. ",
                            RestaurantCategory = RestaurantCategory.Meat,
                            InfoUser = new InfoDescription()
                            {
                                Floor = "Meat",
                                Price = "From 32,80$"
                            }
                        },
                         new Restaurant()
                        {
                            Title = "Desserts",
                            Image = "https://i.imgur.com/qWs4aoC.jpg",
                            Description = "Desserts are a sweet treat for the taste buds. They offer the most delicate and delicious combinations of flavors and textures.",
                            RestaurantCategory = RestaurantCategory.Desserts,

                            InfoUser = new InfoDescription()
                            {
                                Floor = "Desserts",
                                Price = "From 12,25$"
                            }
                        },
                          new Restaurant()
                        {
                            Title = "Drinks",
                            Image = "https://i.imgur.com/bT54zg4.jpg",
                            Description = "We have everything,from refreshing citrus cocktails to traditional, aromatic coffees, the drinks cater to a variety of taste preferences. ",
                            RestaurantCategory = RestaurantCategory.Drinks,

                            InfoUser = new InfoDescription()
                            {
                                Floor = "Drinks",
                                Price = "From 1,75$"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}