using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Transactions;
using System.Data.Entity.Infrastructure;
using Swtor.Business.Entities;
using Swtor.Common;

namespace Swtor.Business
{
    public class DBInit : DropCreateDatabaseIfModelChanges<SwtorContext>
    {
        protected override void Seed(SwtorContext context)
        {
            var testText = new Text
            {
                Name = Constants.TestTextName,
                Content = "This is a test text"
            };

            var testUser = new User
            {
                Firstname = "Test",
                Lastname = "User",
                UserRole = (int)UserRoles.User
            };

            context.Texts.Add(testText);
            context.Users.Add(testUser);

            base.Seed(context);
        }
    }
}
