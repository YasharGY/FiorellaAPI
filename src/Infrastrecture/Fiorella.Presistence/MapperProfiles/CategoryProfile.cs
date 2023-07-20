using AutoMapper;
using Fiorella.Aplication.DTOs.CategoryDTOs;
using Fiorella.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Persistence.MapperProfiles;

public class CategoryProfile:Profile
{
	public CategoryProfile()
	{
		CreateMap<Category,CategoryCreateDto>().ReverseMap();
		CreateMap<Category,CategoryGetDto>().ReverseMap();
		CreateMap<Category,CategoryUpdateDto>().ReverseMap();
	}
}
