using CleanArchMVC.Domain.Entities;
using FluentAssertions;

namespace CleanArchMVC.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {

            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow <CleanArchMVC.Domain.Validation.DomainExceptionValidation>();

        }


        [Fact(DisplayName = "Create Category Negative Id Value Should be Throw Exception")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {

            Action action = () => new Category(1, "Category Name");
            action.Should()
                .Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();

        }

    }
}