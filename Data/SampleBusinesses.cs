using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ConciergeApp.Models;

namespace ConciergeApp.Data
{
    public class SampleBusinesses
    {
        public async static Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<ApplicationDbContext>();

            await db.Database.EnsureCreatedAsync();

            if (!db.Businesses.Any())
            {
                db.Businesses.AddRange(
                    new Business
                    {
                        Name = "Pizza Hut",
                        Address = "10504 W Broadway St, Pearland, TX 77584",
                        Type = "Restaurant",
                        Phone = "(713) 436-1014",
                        Description = "Family-friendly chain known for its made-to-order pizzas.",
                        Url = "http://wwww.order.pizzahut.com",
                        Image = "http://i50.photobucket.com/albums/f342/rjupio/Pizza%20Hut_zpslds42jia.jpg",
                        AvgRating = "3",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 11AM-12AM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                            BusinessId = 1,
                            TimePosted = DateTime.UtcNow,
                            Likes = 9,
                            StarRating = 1,
                            Title = "Bad Delivery Service",
                            Message = "I was promised to have pizza delivered in 45 minutes tops. It arrived after an hour and twenty minutes and it was cold. Even a hungry dog would not eat it. To add insult to injury - their shop is located literally 2 blocks from where I live. It is definitely the last time I use them.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 3,
                                        Message = "I am so SICK of trying to order from Pizza Hut delivery!!! This must be the 3rd time that I decided to order from the Pizza Hut on Broadway where they deliver. I am not far from there... Only 5 minutes or less. But the last 3 times I ordered and was willing to pay for the convenience of delivery. I ended up picking up my order. Because they actually don't have delivery drivers. I called today and they said that they couldn't deliver until an hour and a half from order time, because they didn't have delivery drivers. ** that! I'm paying for the convenience of delivery... And tipping! You are less than a mile from me. Yet want to charge delivery fees, but it will take an hour and a half? ** that! Don't offer delivery... If you don't have the means for delivery! ** you Pizza Hut on Broadway in Pearland, TX!!!!",
                                Image = "http://www.bordeaux-tourism.co.uk/var/ezwebin_site/storage/images/media/images/regards-bordelais/jean-poutge/profil-jean/12599-2-fre-FR/Profil-Jean_format_360x360.jpg",
                                    },



                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 2,
                                        Message = "I placed an order for delivery to the closest location according to their website. They were delivered late and cold. I called several times to the store just to be told that it is an error on the program's estimated time. When I requested more information regarding this error, the sales attendant couldn't provide with a contact information. I asked to speak with the manager to see if he could explain better what was happening to my order. He then decides to be disrespectfully and treat me like a child. As I was explaining the situation, I was interrupted to be asked, 'How did the pizza taste?' I wouldn't know, I hadn't received them. More important not only did he failed to appeased a customer and offer an apology, he had to asked around for the regional manager last name. Anyhow, this is their third and last strike, they just lost another customer."
                                    },

                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 1,
                                        Message = "So when you call your neighborhood Pizza Hut the number is redirected to a call center. Got disconnected at the end of 10 minute order process. Called back and order not in the system so 15 minutes later and order was finally in the system. My problem is this is not Real Customer service. A third party shouldn't be involved in my order process. When I call that store and place order I want to talk to the person directly responsible for my food. So if my order is wrong I can then call the store directly for my complaint. These type of third party calling is another thing wrong with this once great country."
                                    },

                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 0,
                                        Message = "These guys are terrible!"
                                    }
                                }
                            },
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                            BusinessId = 1,
                            isAnonymous = false,
                            TimePosted = DateTime.UtcNow,
                            Likes = 6,
                            StarRating = 5,
                            Title = "Keep the Pearland TX Pizza Hut Open!!!",
                            Message = "It really is a shame that after all this time that Pizza Hut in Pearland TX is being shut down by the corporation. We need this business open. Many many of us even here at Cartridge World next door to Pizza Hut need Pizza Hut. Many people run the stores by themselves. They're small businesses. Our food gets delivered. Where else would we go and get such good service? This is the only store or business I have ever known up in the 50 years of my life that delivers pizza on foot to the nearby businesses extremely fast most of the time within 7 minutes. This is quite a shame that this is happening. This business was doing fine. How much do you need for a business to keep going? I look out my window all the time at the store here at Cartridge World and see them at the window studying delivering pizzas. But yeah you want to close this very important store. Pizza Hut please hear my request to leave the store open.I'm just one person in this whole community and I hope you hear me out because if you need the whole Community we can work that out too. We need the store. Can you give it a chance? Summers coming the business will pick up. If you think its not doing good I assure you we need this business in this strip mall and for the surrounding areas.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 5,
                                        Message = "I went to this store. The workers are kind and friendly fast and courteous. What more do you want from your workers? That's what I asked. They did the best they could and you you're going to shut them down for doing the best they could. I'm wondering if some of the policies you have on getting in the way of your progress because I see these gentleman working non-stop, serving their community, getting pizza there hot fresh and fast. Isn't that what you require of a store? please consider keeping this business open. Like I said summer is coming hear me out."
                                    },

                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 4,
                                        Message = "This Pizza Hut gives that comfy cozy dining experience plus I love their caesar salad, their mushroom soup and their crab salad roll. Their staff are also very very warm and accommodating. However, I couldn't give their pizza the thumbs up. Over the years, the dough has become dry and oily. Their toppings dry and lacking. You will enjoy the pizza a bit if you eat it right there in the restaurant but once you eat it later, it tastes stale and plain. Their pasta also tastes uncooked and hard at times, and though I love their soup recipes, more often than not it taste burnt. They should really look into what they are doing wrong. I have loved Pizza Hut more than our local pizza place before but not anymore. I am still satisfied with them but I do not wish to be only satisfied. I only dine out once in a while and so if I dine out I wish it to be a HAPPY experience.Were you able to take a picture?",
                                        Image="http://www.bordeaux-tourism.co.uk/var/ezwebin_site/storage/images/media/images/regards-bordelais/jean-poutge/profil-jean/12599-2-fre-FR/Profil-Jean_format_360x360.jpg"
                                    },



                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 3,
                                        Message = "Pizza Hut was a lot different more than a decade ago when they weren't so focused on trying to sell more pizzas. Back then their pizza was actually really good, and I always looked forward to eating there during special occasions. Now they have all these affordable promos and more people are eating there, and it has led to a decrease in quality of their food. Sometimes there are barely enough toppings, sometimes even the soup isn't hot, and the servers all seem too busy to pay any attention. I miss the Pizza Hut during my childhood when eating there was always a special time. Now it just seems like any other cheap pizza joint. What a shame. It used to be that when I thought of great pizza, Pizza Hut came to mind first. Now I only think about them when I want to eat cheap good-enough pizza that looks premium, even though it's not."
                                    },

                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 2,
                                        Message = "Why are they shutting it down? I went to Pizza Hut for my first time today and it was delicious. I'mma be full all day. I would rate it 100 if I could. Everybody gave free refills and each drink was 1 dollar each. I enjoyed my time there. I do not know why so many bad reviews but it's good. Maybe it's the delivery people having a problem with. I was happy. I got 1 suggestion. 1 the pizza, the toppings part of the pizza should be bigger and the bread of it should be smaller.",
                                        Image = "http://www.bordeaux-tourism.co.uk/var/ezwebin_site/storage/images/media/images/regards-bordelais/jean-poutge/profil-jean/12599-2-fre-FR/Profil-Jean_format_360x360.jpg"
                                    },



                                    new Comment
                                    {
                                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                        TimePosted = DateTime.UtcNow,
                                        Likes = 1,
                                        Message = "Are you serious? They've closed without delivering my pizza!!?? Never again.",
                                        Image = "http://www.bordeaux-tourism.co.uk/var/ezwebin_site/storage/images/media/images/regards-bordelais/jean-poutge/profil-jean/12599-2-fre-FR/Profil-Jean_format_360x360.jpg"
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Domino's Pizza",
                        Address = "9430 Broadway St, Ste 160, Pearland, TX 77584",
                        Type = "Restaurant",
                        Phone = "(281) 412-3678",
                        Description = "Delivery/carryout chain offering a wide range of pizza, plus chicken & other sides.",
                        Url = "http://www.dominos.com",
                        Image = "http://i50.photobucket.com/albums/f342/rjupio/Dominos_zpswua30s8d.jpg",
                        AvgRating = "3",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 10AM-1AM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                    {
                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                        BusinessId = 2,
                        isAnonymous = false,
                        TimePosted = DateTime.UtcNow,
                        Likes = 4,
                        StarRating = 5,
                        Title = "Great Delivery From Domino's",
                        Message = "Currently stuck in Pearland TX - where everything is way below par to what I'm used to - having lived on the San Francisco peninsula for all of my life i.e over 60 yrs. Domino's Pizza & the delivery rocks out here as far as I'm concerned! Maybe they just try harder because while the economy is bad everywhere...one assumes it's even worse here. My pizzas are correctly made/cooked properly & delivered while still too hot to touch. Probably the one thing here I've got no problem with.",
                        Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 3,
                                    Message = "Yeah, they're awesome!"
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 2,
                                    Message = "Thank goodness, you guys are the best."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 1,
                                    Message = "I order from Domino's often and have not had any problems with them other than forgetting a sauce once. Every time I receive my order it was fairly quick, hot and fresh including the order I placed and received tonight. Amazing pizza, chicken and dessert."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 0,
                                    Message = "I concur, true super heroes."
                                }
                            }
                        },
                        new Feedback
                    {
                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                        BusinessId = 2,
                        isAnonymous = false,
                        TimePosted = DateTime.UtcNow,
                        Likes = 5,
                        StarRating = 1,
                        Title = "I could have died waiting for this pizza!",
                        Message = "I order pizza online so I wouldn't have to wait. I'm a stage 4 cancer patient so I was feeling good for a change and I wanted to celebrate by eating a slice of pizza with my family. The website said it would be ready. When I get to the Domino's on 941 S General McMullen Dr San Antonio, TX 78237 They tell me that 1 of the 2 pizza I order online was not made and that they would make right away and it would about 15 min's. I ask for them to redo both pizza cause I like 2 fresh pizza not 1 that would be 15 min's old. After 20 mins I ask about my pizzas and again they said there was a mistake made and would remake them again.I was getting frustrated and the manager said he would give me some cheesy bread if I would stop having a bad attitude. I a 55 year old man.I don't appreciate a kid manager accusing me of having a bad attitude after they mess up twice. 15 mins later they only remade one so I ended up with one crispy pizza and one soggy pizza that was 15 min old. The manager ignored me after that and they overcharge me and I had to get that fixed. Terrible experience.",
                        Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 4,
                                    Message = "I understand with a deal like the pizzas being 50% off would attract a lot of customers but after ordering online my husband got a call from the store saying our order would take 3-4 hrs to make. No biggie - we just canceled our order. But not even ten minutes after getting off the phone they call us saying they are at our house with said pizza. This isn't the first time we've had issues with this particular store."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 3,
                                    Message = "Here's another one. On Friday night, I placed an order with Domino's Pizza online. The online status showed my order was confirmed and the order was being processed. The order showed that I should expect a 52-62 minute delivery time. After an hour and twenty minutes, I called the store to check on the progress of my order. I was told 'Oh, we cancelled your order, we were really busy about that time.' I could not believe the cavalier tone of the person I was speaking to. I asked 'why was I not informed of this?', and was told 'That's a good question.' There was no sense of embarrassment. There was no offer to correct the issue, or rush a replacement order to me. In fact I was told that if I wanted to re - order they would not be able to expedite the process at all.It seems that cancelling orders is part of normal practice for this Domino's. By this time it was after 10 pm, and there were no other options to order out. I enjoyed a meal of leftovers that night. This was a Domino's in Indianapolis, IN.I gave this review 2 stars, as maybe Domino's has implemented a new diet program to help customer lose weight by canceling their orders. If that was the case, it was effective."
                                }
                            }
                    }
                        }
                    },
                    new Business
                    {
                        Name = "Papa John's Pizza",
                        Address = "10223 W Broadway St, Pearland, TX 77584",
                        Type = "Restaurant",
                        Phone = "(281) 412-7272",
                        Description = "Take-out/delivery chain offering classic & specialty pizzas, wings & breadsticks, plus desserts.",
                        Url = "https://www.papajohns.com/",
                        Image = "http://i50.photobucket.com/albums/f342/rjupio/Papa%20Johns_zps99tg4c8k.jpg",
                        AvgRating = "3",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 10:30AM-12AM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                    {
                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                        BusinessId = 3,
                        isAnonymous = false,
                        TimePosted = DateTime.UtcNow,
                        Likes = 3,
                        StarRating = 4,
                        Title = "Top Notch Service!",
                        Message = "Every time I go in, there is a Lady I believe her name is Elrin working with the crust. She always goes out of her way to make sure people that are waiting gets their pizza fast. People working front counter usually too busy talking to other employees, drivers. Tonight Ashley ** was the best. She was on top of everything. Two thumbs up to these Lady's!!! Great Job.",
                        Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 1,
                                    Message = "Although my order has been delivered wrong a couple times the food has always been hot! The employees have always made it right when they did mess up!! The garlic bread sticks are the best around :)"
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 0,
                                    Message = "I just want to say I went to your Pearland store in Pearland, Texas and ask them to make me a small pizza with a thin crust. Normally, they couldn’t make it unless it was a large pizza. The pizza was so good. The person that made the pizza did a great job. I ate the whole pizza. That’s how good it was. The service was excellent and they need to be rewarded. They walk the extra mile to satisfy their customers and I like that. I will be going back tomorrow. What a great job they did."
                                }
                            }
                    },
                    new Feedback
                    {
                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                        BusinessId = 3,
                        isAnonymous = false,
                        TimePosted = DateTime.UtcNow,
                        Likes = 2,
                        StarRating = 4,
                        Title = "Top Notch Service -- Not!",
                        Message = "I had ordered a pizza on-line today and called the store to confirm. The so called manager Mr. **, was the rudest person I have ever met on-line. He hangs up on the customer. After calling back he continues to argue with me as he cannot locate the order. At that point I gave up and ordered my pizza from pizza hut!!! These people have no manners and no courtesy.",
                        Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 1,
                                    Message = "I just ordered a one topping medium pizza and the person on the phone just shouted out the price after taking my order and hung up on me. Now I have a hungry child and a bill for 17.00 dollars and an hour wait. I don't believe a medium pizza with one topping is worth it and would have stated so if the person on the phone gave me a chance. And because of this I will never order papa johns again and that's a shame because I liked papa john's recipe over all the other chains. And just to be a nice guy I still gave the delivery driver a tip. When I should have just sent the pizza back. And just to get all the dumb stuff out the way I did call asking about the specials."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 2,
                                    Message = "I called the Papa John's pizza shop on Broadway Street in Pearland TX. Ordered a pizza for delivery. They took my name, number, and address and told me it would be about 45 minutes. An hour and a half later I had to call back because my pizza and never showed up. Turns out the person who took my order had the wrong address so they cancelled the order. I asked the manager why wasn't I called and of course they wrote down the wrong phone number as well. Such incompetence is not tolerated. I shall never order from Papa John's again so I had Pizza Hut deliver."
                                }
                            }
                    }

                        }
                    },
                    new Business
                    {
                        Name = "Little Caesars Pizza",
                        Address = "11037 Shadow Creek Pkwy, Pearland, TX 77584",
                        Type = "Restaurant",
                        Phone = "(713) 340-0209",
                        Description = "Carry-out chain featuring chicken wings, signature breadsticks & pizza tossed from housemade dough.",
                        Url = "http://littlecaesars.com/en-us/#pizzas",
                        Image = "http://i50.photobucket.com/albums/f342/rjupio/Little%20Caesars_zpsa29v47pl.jpg",
                        AvgRating = "3",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 11AM-12AM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                    {
                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                        BusinessId = 4,
                        isAnonymous = false,
                        TimePosted = DateTime.UtcNow,
                        Likes = 4,
                        StarRating = 1,
                        Title = "What's this in my food!?!",
                        Message = "I found hair in my food about an inch or longer with the root still on it. It's a thicker hair so I know it didn't come from someone's head.",
                        Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 3,
                                    Message = "I use Little Caesars quite often, however the last time I ordered a pizza it was so salty we couldn't even eat it. I don't usually take food back because I've seen firsthand what people do to those who complain. Very dissatisfied. Prob won't go back."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 2,
                                    Message = "Geez -- that is disgusting!"
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 1,
                                    Message = "I was walking home from the mall and decided to pop in to Little Caesars to use the LAST $5 of MY BIRTHDAY MONEY for a little treat (or so I thought). Turns out the stuffed crazy bread I ordered ended up giving me food poisoning. I feel terrible right now (as if I didn't already). I have bad gas, am feeling hot, and I feel like I'm going to vomit. Plus, it was already fairly cold when I got it. The parmesan or whatever had turned yellow and the grease had dried and was causing the SCB to stick to the box like glue. I am so pissed I could SUE THEM. It has just contributed to a load of already existing health problems. Plus, that was my last $5 I got for my birthday, and I ended up spending it on a one way ticket to my bathroom. These people should be ashamed of themselves because this is just pathetic."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 0,
                                    Message = "Pretzel Crust Pizza and The Gross Restaurant in Pearland TX - I wanted for months to try this pizza as I love soft pretzels and cheddar cheese. I had that opportunity today and I will say I was totally disgusted not only by the awful way the pizza looked but the way it tasted. Also the restaurant was dirty. I have worked in a pizza place and I would like to know why these people don't wear gloves or hair nets."
                                }
                            }
                    },
                    new Feedback
                    {
                        ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                        BusinessId = 4,
                        isAnonymous = false,
                        TimePosted = DateTime.UtcNow,
                        Likes = 3,
                        StarRating = 4,
                        Title = "Great Deal on Pizzas!",
                        Message = "$5. Little Caesars 'Hot & Ready' Pizza. Pizza was ready in seconds when I arrived. Hot & delicious. I'm hooked. Yummy.",
                        Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 4,
                                    Message = "I had never tried Little Caesars before because. We didn't have one here where I live but they have one now and I went there Sunday before last and got a Pizza and only cost 5 dollars for LARGE Pepperoni and 10 for Sausage and pepperoni and it taste good. A five dollar large! You can't beat that. I appreciate them. I appreciate that they don't charge you an arm and leg and you get your money's worth of meat too. I've been back there 4 times since then! I also went today, got another pizza. They haven't let me down at all."
                                },

                                new Comment
                                {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "Indeed it is!!"
                                }
                            }
                    }
                        }
                    },
                    new Business
                    {
                        Name = "B & B Butchers",
                        Address = "1814 Washington Ave St, Houston, TX 77007",
                        Type = "Restaurant",
                        Phone = "(832) 962-4745",
                        Description = "A vintage bakery has been converted into an upscale steakhouse with an attached butcher shop & deli.",
                        Url = "http://bbbutchers.com/menus-2/butcher-shop-menu/",
                        Image = "https://cdn0.vox-cdn.com/thumbor/l12YxE9sbkQ6b5UVq2lyfZgwfSw=/288x0:4640x3264/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/48504905/B__B_Inside.0.0.0.JPG",
                        AvgRating = "4",
                        PriceMin = 30,
                        PriceMax = 100,
                        HoursOpen = "Sun-Sat 11AM-11PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                            BusinessId = 5,
                            TimePosted = DateTime.UtcNow,
                            Likes = 9,
                            StarRating = 4,
                            Title = "Top-tier Steakhouse in Houston",
                            Message = "This steakhouse is obsessed with dry-aged meats, and the results are delicious. Treat yourself to a flight of lamb, pork, and beef bacon before splitting the massive Gearhart Ranch wagyu cowboy cut steak with your dinner date, or splurge on the restaurant's certified authentic Kobe beef — it's one of only nine restaurants in the country to boast such credentials.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "I was impressed with the quality of the food and the service from the staff."
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "BCN Taste & Tradition",
                        Address = "4210 Roseland St, Houston, TX 77006",
                        Type = "Restaurant",
                        Phone = "(832) 834-3411",
                        Description = "Set in a 1920s home, this contemporary Spanish fine-dining spot presents classic Catalan flavors.",
                        Url = "N/A",
                        Image = "https://cdn0.vox-cdn.com/thumbor/gKBH9wxlncC9PFNdXMv7bjswfAA=/53x0:906x640/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/50101065/bcntaste-fb.0.0.jpg",
                        AvgRating = "5",
                        PriceMin = 50,
                        PriceMax = 150,
                        HoursOpen = "Tue-Sat 5PM-10PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                            BusinessId = 6,
                            TimePosted = DateTime.UtcNow,
                            Likes = 9,
                            StarRating = 5,
                            Title = "Best of Barcelona brought to Houston",
                            Message = "Taking its name from Barcelona, this Midtown eatery showcases the best of Spanish cuisine. The upscale, Mediterranean-influenced setting is ideal for enjoying delicate, razor-thin slices of jamón iberico, fresh beef tartare, and seared foie gras. A stellar selection of Spanish wines rounds out the experience, which is decidedly cheaper than booking that trip to Barca.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 3,
                                    Message = "The fish was perfectly cooked and the gin drinks amazing."
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Blue Nile Ethiopian Restaurant",
                        Address = "9400 Richmond Ave, Houston, TX 77063",
                        Type = "Restaurant",
                        Phone = "(713) 782-6882",
                        Description = "Guests scoop up hearty stews using injera bread at this casual Ethiopian spot.",
                        Url = "http://www.bluenilerestaurant.com",
                        Image = "https://cdn0.vox-cdn.com/thumbor/-cwO6jUyoRR5aDFl7SZLpnhoFiw=/6x0:479x355/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/46064366/blue_nile_ethiopian_houston_map.0.0.jpg",
                        AvgRating = "3.5",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 11AM-11PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                            BusinessId = 7,
                            TimePosted = DateTime.UtcNow,
                            Likes = 5,
                            StarRating = 4,
                            Title = "Add this spot to your Ethnic Eatery List",
                            Message = "This Houston institution is known for its kifto (ground beef tossed with a spicy, buttery sauce) and other authentic Ethiopian dishes. Grab a freshly-made injera to scoop up the savory sauces here, and save room for a glass of tej, a sweet honey-based wine made in-house.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 1,
                                    Message = "Good place to eat at; however, not the best Ethiopian food I've tasted."
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Brennan's of Houston",
                        Address = "3300 Smith St, Houston, TX 77006",
                        Type = "Restaurant",
                        Phone = "(713) 522-9711",
                        Description = "New Orleans character & cuisine shine at this decadent eatery serving turtle soup, oysters & more.",
                        Url = "http://wwww.brennanshouston.com",
                        Image = "https://cdn0.vox-cdn.com/thumbor/89Xk3dom4GbG5Wca6yeA7qtmkgA=/33x0:566x400/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/49238101/1505355_10152002600926045_168238585_n.0.0.jpg",
                        AvgRating = "4",
                        PriceMin = 30,
                        PriceMax = 90,
                        HoursOpen = "Sun-Sat 11AM-10PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                            BusinessId = 8,
                            TimePosted = DateTime.UtcNow,
                            Likes = 9,
                            StarRating = 4,
                            Title = "Classy Lousiana Cajun Food",
                            Message = "Open for more than 40 years in H-Town, Brennan’s is a Cajun staple. Order up a dozen oysters before digging into grilled redfish or blue crab-stuffed flounder and a side of those bacon-braised collard greens. If you’ve really got cash to blow, order up the crab & caviar nachos, topped with a full pound of lump crab and an ounce of Petrossian caviar, at Brennan’s courtyard bar. Even a hungry dog would not eat it. To add insult to injury - their shop is located literally 2 blocks from where I live. It is definitely the last time I use them.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "The mahi-mahi wasnt as fab as the other entrees, but the duck was awesome."
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Crawfish & Noodles",
                        Address = "11360 Bellaire Blvd #990, Houston, TX 77072",
                        Type = "Restaurant",
                        Phone = "(281) 988-8098",
                        Description = "Spicy crawfish tops the menu of Vietnamese & Cajun fare at this contemporary venue with happy hours.",
                        Url = "N/A",
                        Image = "https://cdn0.vox-cdn.com/thumbor/hEMU2g5pk7w4sAJiEunzlVm5YFA=/9x0:476x350/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/49238105/crawfish_and_noodles_houston.0.0.jpg",
                        AvgRating = "4",
                        PriceMin = 15,
                        PriceMax = 75,
                        HoursOpen = "Sun-Sat 3PM-10PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                            BusinessId = 9,
                            TimePosted = DateTime.UtcNow,
                            Likes = 8,
                            StarRating = 4,
                            Title = "Like Brennan's, Just More Affordable!",
                            Message = "If it seems like a strange combination, don't fear – Crawfish & Noodles serves up some of the best mudbugs in town, and it's the perfect time to order up a pound (or ten). Order yours extra spicy, and pair with an order of crispy Cajun fries.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "I ordered six, they gave me 8 and I wished I had a dozen, SOOOOOOO good.",
                                    Image = "http://i50.photobucket.com/albums/f342/rjupio/Lady_Bunny_zpsenf4hlw7.jpg"
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Etoile Cuisine et Bar",
                        Address = "1101-11 Uptown Park Blvd, Houston, TX 77056",
                        Type = "Restaurant",
                        Phone = "(832) 668-5808",
                        Description = "Sophisticated French eatery with a modern farmhouse interior serving traditional & seasonal menus.",
                        Url = "http://etoilecuisine.com/",
                        Image = "https://cdn0.vox-cdn.com/thumbor/_0X28-EWl_WuaIZgn__s1wYBwN8=/9x0:476x350/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/46064388/etoile_cuisine_et__bar_houston.0.0.jpeg",
                        AvgRating = "5",
                        PriceMin = 50,
                        PriceMax = 175,
                        HoursOpen = "Sun-Sat 11AM-10PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Stephen")).Id,
                            BusinessId = 10,
                            TimePosted = DateTime.UtcNow,
                            Likes = 6,
                            StarRating = 5,
                            Title = "French Cuisine at its Finest",
                            Message = "French classics like beef tartare, duck a l'orange, and foie gras torchon are the focal point at this upscale Uptown eatery, but don't sleep on the seasonal menu. Chef Philippe Verpiande's use of local produce and fresh seafood makes it one of the best in town.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "They have a decent wine selection and good atmosphere for a nice date night"
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Hugo's",
                        Address = "1600 Westheimer Rd, Houston, TX 77006",
                        Type = "Restaurant",
                        Phone = "(713) 524-7744",
                        Description = "Modern Mexican fare & shaken margaritas prepared tableside star at this upscale Montrose spot.",
                        Url = "http://www.hugosrestaurant.net/",
                        Image = "https://cdn0.vox-cdn.com/thumbor/LevHDKOSecUwWMRZy1K2kPhaflA=/43x0:756x535/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/49238109/hugos-fb.0.0.jpg",
                        AvgRating = "4",
                        PriceMin = 20,
                        PriceMax = 80,
                        HoursOpen = "Sun-Sat 11AM-12AM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                            BusinessId = 11,
                            TimePosted = DateTime.UtcNow,
                            Likes = 9,
                            StarRating = 4,
                            Title = "Contemporary Mexican Cuisine with high-profile Chef!",
                            Message = "Chef Hugo Ortega’s namesake restaurant continues to earn him recognition in and outside of Houston, and that’s due in large part to the quality of these authentic, updated Mexican dishes. Pretty much everything here is made in-house, down to grinding the chocolate for mole sauce and freshly-baked tortillas.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 2,
                                    Message = "Ordered lamb dish w/ tortilla (was alright), grilled seafood, etc."
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Hunky Dory Tavern",
                        Address = "1801 N Shepherd Dr a, Houston, TX 77008",
                        Type = "Restaurant",
                        Phone = "(713) 864-2450",
                        Description = "Contemporary British–American tavern serving elevated pub fare, cocktails & wood-fired specialties.",
                        Url = "http://treadsack.com/hunkydory/",
                        Image = "https://cdn0.vox-cdn.com/thumbor/ASMHOg72LBMLDEqSfgjJwdhQGUQ=/341x0:5674x4000/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/51193699/DSC_7160_Hunky_Dory_Outside_Photo_by_Ellie_Sharp.0.0.jpg",
                        AvgRating = "3",
                        PriceMin = 25,
                        PriceMax = 85,
                        HoursOpen = "Sun-Sat 11AM-10PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                            BusinessId = 12,
                            TimePosted = DateTime.UtcNow,
                            Likes = 5,
                            StarRating = 4,
                            Title = "English Upscale Comfort Food",
                            Message = "Everything's alright at this sleek Heights eatery. Offering upscale comforting fare in a cozy environment, Hunky Dory has become a favorite haunt for folks in the neighborhood. Start off your dinner with snapper tartare or pastry-wrapped black pudding, then dig into a comforting bowl of lamb cavatelli or HD's Rabbity Pudding, a take on the classic Yorkshire, for ideal fall fare.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Mike")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 1,
                                    Message = "Fish pie had nice flavors, though potatoes topping was slightly burnt."
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Izakaya",
                        Address = "318 Gray St, Houston, TX 77002",
                        Type = "Restaurant",
                        Phone = "(713) 527-8988",
                        Description = "Casual pub offering globally inspired takes on Japanese small plates, with outdoor patios.",
                        Url = "http://houstonizakaya.com/",
                        Image = "https://cdn0.vox-cdn.com/thumbor/lZORZjeFoqqHRGkvS_2s-lea6qs=/341x0:5674x4000/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/48504915/DSC_4186_Izakaya_Interior_Photo_by_Ellie_Sharp.0.0.jpg",
                        AvgRating = "3",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 11AM-11PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                            BusinessId = 13,
                            TimePosted = DateTime.UtcNow,
                            Likes = 9,
                            StarRating = 4,
                            Title = "Wow, a Japanese-Texas Fusion Restaurant!",
                            Message = "If the fact that Izakaya offers Texas’ largest selection of Japanese whisky isn’t enough to sway you, the small plates certainly will. Try the tuna poke or duck and shrimp shumai, and don’t leave without trying the bacon-fried mochi for a true taste of Japanese-Texas fusion.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Randy")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "The service was very good, but the food was only ok for a high end restaurant"
                                    }
                                }
                            }
                        }
                    },
                    new Business
                    {
                        Name = "Pondicheri",
                        Address = "Gables West Ave, 2800 Kirby Dr B132, Houston, TX 77098",
                        Type = "Restaurant",
                        Phone = "(713) 522-2022",
                        Description = "Industrial-chic spot for Indian combo plates & unique dishes inspired by the streets of Mumbai.",
                        Url = "http://www.pondichericafe.com/",
                        Image = "https://cdn0.vox-cdn.com/thumbor/_BcoTyZ2wJlxBUK0nRlOPJI6oYI=/9x0:476x350/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/46068206/pondicheri_counter_houston.0.0.0.0.jpg",
                        AvgRating = "4",
                        PriceMin = 5,
                        PriceMax = 50,
                        HoursOpen = "Sun-Sat 8AM-10PM",
                        Feedbacks = new List<Feedback>
                        {
                            new Feedback
                            {
                            ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Sarah")).Id,
                            BusinessId = 14,
                            TimePosted = DateTime.UtcNow,
                            Likes = 21,
                            StarRating = 4,
                            Title = "Wonderful Indian Cafe in MidTown",
                            Message = "This modern Indian spot is a good call for breakfast, lunch, or dinner, thanks to consistent execution and perfectly-spiced dishes. Try aloo paratha (carrot roti stuffed with mashed spiced potatoes) instead of your typical breakfast burrito, or order up a vegetable frankie served with peanut chutney and “Desi fries” for a lunch that you’ll keep coming back to.",
                            Comments = new List<Comment>
                                {
                                    new Comment
                                    {
                                    ApplicationUserId = (db.ApplicationUsers.FirstOrDefault(u => u.FirstName == "Josie")).Id,
                                    TimePosted = DateTime.UtcNow,
                                    Likes = 6,
                                    Message = "A must go to place for great spices and flavor."
                                    }
                                }
                            }
                        }
                    }
                );
                db.SaveChanges();
            }
        }
    }
}
