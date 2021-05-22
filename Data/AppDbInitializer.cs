using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();       
                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        bookTitle="1st book",
                        bookDescription="asp.net core",
                        isRead=true,
                        dateRead =DateTime.Now.AddDays(-10),
                        bookRate=100,
                        bookCoverUrl="http://google.com",
                        bookDateAdded=DateTime.Now.AddDays(-30),
                        genere="movie",
                        bookAuthor="Amruth"
                    },
                    new Book()
                    {
                        bookTitle = "2nd book",
                        bookDescription = "java",
                        isRead = true,
                        dateRead = DateTime.Now.AddDays(-20),
                        bookRate = 55,
                        bookCoverUrl = "http://google.com",
                        bookDateAdded = DateTime.Now.AddDays(-2),
                        genere = "drama",
                        bookAuthor = "lakshman"
                    },
                    new Book()
                    {
                        bookTitle = "3rd book",
                        bookDescription = "angular",
                        isRead = false,
                        bookCoverUrl = "http://google.com",
                        bookDateAdded = DateTime.Now,
                        genere = "action",
                        bookAuthor = "rama"
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
