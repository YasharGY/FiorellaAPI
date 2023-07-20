using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Persistence.Exceptions;

public interface IBaseException
{
	public int StatusCode { get; set; }
	public string CustomMessage { get; set; }
}
