using System;
using System.Linq;

namespace LeaderEdu.Models
{
    public class SampleData
    {
        public static void Initialize(LeaderEduContext context)
        {
            if (!context.User.Any())
            {
                context.User.AddRange(
                    new User
                    {
                        guid="123456",
                        LastName = "Туралиева",
                        FirstName = "Ирина",
                        MiddleName = "Игоревна",
                        email = "i.turaliyeva@gmail.com",
                        Password = "123456",
                        Sex = 2,
                        Phone = "77017207229",
                        Type = 2

                    },
                     new User
                     {
                         guid = "654321",
                         LastName = "Мырзагара",
                         FirstName = "Медет",
                         MiddleName = "Ердосулы",
                         email = "myrzagara@gmail.com",
                         Password = "123456",
                         Sex = 1,
                         Phone = "77023501262",
                         Type = 1

                     }
                );
                context.SaveChanges();
            }

        }
    }
}
