using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Domain.Entities;

public class Slider :BaseEntity
{
	public Guid Title { get; set; }
	public Guid Description { get; set; }
}
