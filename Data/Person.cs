using FluentValidation;

namespace BlazorServiceWithFluentValidation.Data.Person
{
    class Person
    {
        public string Name { get; set; }
    }

    class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("You must provide a name! Boo!!");
        }
    }

}