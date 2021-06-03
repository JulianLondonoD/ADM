using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADM.PruebaTecnica.UnitTest.Mocks.Data
{
    public class ADMDbContextMock
    {
        public Mock<ADMDbContextMock> _context { get; set; }

        public ADMDbContextMock()
        {
            _context = new Mock<ADMDbContextMock>();
        }
    }
}
