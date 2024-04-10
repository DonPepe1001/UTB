using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UTB.Data_Entities;

namespace UTB
{
    public class DataContext : DbContext
    {
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ChatSession> ChatSessions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DataContext() : base("name=con")
        {
        }
    }
}
