using System;
using Microsoft.EntityFrameworkCore;

namespace NestProject.DAL
{
	public class NestContext : DbContext
	{
		public NestContext(DbContextOptions<NestContext> options) :base(options)
		{

		}



	}
}

