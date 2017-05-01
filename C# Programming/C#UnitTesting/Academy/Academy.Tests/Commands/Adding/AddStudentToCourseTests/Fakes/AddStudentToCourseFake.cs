using Academy.Commands.Adding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Core.Contracts;

namespace Academy.Tests.Commands.Adding.AddStudentToCourseTests.Fakes
{
    class AddStudentToCourseFake : AddStudentToCourseCommand
    {
        public AddStudentToCourseFake(IAcademyFactory factory, IEngine engine) : base(factory, engine)
        {
        }

        public IAcademyFactory Factory
        {
            get
            {
                return this.factory;
            }
        }
        public IEngine Engine
        {
            get
            {
                return this.engine;
                 
            }
        }
    }
}
