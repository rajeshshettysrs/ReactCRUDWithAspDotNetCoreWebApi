using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class DonationDbContextModel : DbContext
    {
        public DonationDbContextModel(DbContextOptions<DonationDbContextModel> options) : base(options)
        {

        }

        public DbSet<DonationCandidateModel> DonationCandidateModel { get; set; }
    }
}