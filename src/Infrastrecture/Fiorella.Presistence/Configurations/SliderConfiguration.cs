using Fiorella.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Persistence.Configurations;

public class SliderConfiguration:IEntityTypeConfiguration<Slider>
{
	public void Configure(EntityTypeBuilder<Slider> builder)
	{
		builder.Property(x => x.Title).IsRequired(true).HasMaxLength(70);
		builder.Property(x => x.Description).IsRequired(false).HasMaxLength(500);
	}
}
