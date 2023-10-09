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
                            Image = "blob:https://web.telegram.org/2d68ce0c-9b43-4eed-a14f-2dde0c3e1cdc",
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
                            Image = "blob:https://web.telegram.org/cb88a7ee-57fe-403c-be4e-6f66b97c362c",
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
                            Image = "blob:https://web.telegram.org/1528a30d-a049-41ba-9c23-c023d7f45a55",
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
                            Image = "blob:https://web.telegram.org/7f66f6b3-4fea-4b1a-a1fa-bfeb2b895e21",
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
                            Image = "blob:https://web.telegram.org/e7182ab8-16a6-47a5-8e69-62149aef4892",
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
                            Image = "blob:https://web.telegram.org/e0990930-f1a0-424e-b451-94817e920791",
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
                            Image = "https://www.engelvoelkers.com/wp-content/uploads/2014/07/pizza-stock.jpg",
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
                            Image = "https://th.bing.com/th/id/OIP.sbPJgFxdcqvukdivbeNLQgHaHa?pid=ImgDet&rs=1",
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
                            Image = "https://th.bing.com/th/id/OIP.Z1VBWETVHTV_Zl88104fsQHaHa?pid=ImgDet&rs=1",
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
                            Image = "https://th.bing.com/th/id/OIP.tW8ue6EZnpsH783xktdxXQHaHa?pid=ImgDet&rs=1",
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
                            Image = "https://th.bing.com/th/id/R.954a636ed39f0a66375f402a62993fd5?rik=QgkKI1kewv%2bV9A&riu=http%3a%2f%2fwww.todayifoundout.com%2fwp-content%2fuploads%2f2014%2f06%2fcocktail.jpg&ehk=MkrJ2MJzFvqqV%2fhachVdMWXXQzscTF1j5RIZ%2bF0e7ts%3d&risl=&pid=ImgRaw&r=0",
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