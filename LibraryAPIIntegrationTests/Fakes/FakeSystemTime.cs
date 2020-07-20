using LibraryApi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAPIIntegrationTests.Fakes
{
    public class FakeSystemTime : ISystemTime
    {
        public DateTime GetCurrent()
        {
            return new DateTime(1989, 8, 24, 23, 59, 59);
        }
    }
}
