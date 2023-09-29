using Microsoft.EntityFrameworkCore;
using System;

public class DB
{
	public DbSet<MovementPacket> Packets { get; set; }
	public DB()
	{
	}
}
