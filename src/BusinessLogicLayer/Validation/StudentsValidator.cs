using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class StudentsValidator : AbstractValidator<StudentModel>
    {
        public StudentsValidator()
        {

        }
    }
}
