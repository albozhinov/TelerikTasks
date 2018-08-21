using Academy.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Tests.Abstractions.Mocks
{
    internal class UserMock : User
    {
        public UserMock(string username) : base(username)
        {
        }
    }
}
