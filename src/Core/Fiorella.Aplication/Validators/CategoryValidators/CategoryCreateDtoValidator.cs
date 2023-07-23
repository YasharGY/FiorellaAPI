using Fiorella.Aplication.DTOs.CategoryDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Aplication.Validators.CategoryValidators;

public class CategoryCreateDtoValidator:AbstractValidator<CategoryCreateDto>
{
	public CategoryCreateDtoValidator()
	{
		RuleFor(c => c.name).NotEmpty().MaximumLength(30);
		RuleFor(c => c.description).NotNull().NotEmpty().MaximumLength(350);
	}
}
