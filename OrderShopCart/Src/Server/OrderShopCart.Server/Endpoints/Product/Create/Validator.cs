using FluentValidation;

namespace OrderShopCart.Server.Endpoints.Product;

public class CreateProductValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductValidator()
    {
        RuleFor(p => p.Price)
            .NotEmpty()
            .NotNull()
            .WithMessage("قیمت محصول را وارد کنید");

        RuleFor(p => p.Title)
            .NotEmpty()
            .NotNull()
            .WithMessage("عنوان محصول را وارد کنید")
            .MaximumLength(100)
            .WithMessage("عنوان مصحول نباید بیشتر از 100 کاراکتر باشد");

        RuleFor(p => p.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("برای محصول توضیحاتی اضافه کنید");
    }
}
