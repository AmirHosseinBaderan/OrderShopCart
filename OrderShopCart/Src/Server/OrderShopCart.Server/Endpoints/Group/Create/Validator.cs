using FluentValidation;

namespace OrderShopCart.Server.Endpoints.Group;

public class CreateGroupValidator : AbstractValidator<CreateGroupRequest>
{
    public CreateGroupValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100)
            .WithMessage("طول نام گروه نباید بزرگنر از 100 کاراکتر باشد");

        RuleFor(x => x.Title)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100)
            .WithMessage("طول عنوان گروه نباید بزرگنر از 100 کاراکتر باشد");
    }
}
