﻿using Postman2.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman2.Domain.Entities
{
	public class BankAccount : EntityBase<Guid>
	{
		public Person? Owner { get; set; }
		public decimal Balance { get; set; }
	}
}
