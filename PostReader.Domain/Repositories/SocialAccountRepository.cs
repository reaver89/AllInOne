using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostReader.Data.Context;
using PostReader.Data.Models;

namespace PostReader.Data.Repositories
{
    public class SocialAccountRepository : BaseRepository<SocialAccount>, ISocialAccountRepository
    {
        public SocialAccountRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
