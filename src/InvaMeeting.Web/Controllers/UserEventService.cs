using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvaMeetings.Web.Data;
using InvaMeetings.Web.Model;
using System.Linq;



namespace InvaMeetings.Web.Controllers
{
    public interface UserEventService
    {
        Task<List<UserEventModel>> Get();
        Task<UserEventModel> Update(UserEventModel userEventModel);
        Task<UserEventModel> Add(UserEventModel userEventModel);
    }


    public class UserEventServices : UserEventService
    {
        private readonly DatabaseContext _context;

        public UserEventServices(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<UserEventModel>> Get()
        {
            return await _context.userEventModelList.ToListAsync();
        }


        public async Task<UserEventModel> Add(UserEventModel userEventModel)
        {
            _context.userEventModelList.Add(userEventModel);
            await _context.SaveChangesAsync();
            return userEventModel;
        }

        public async Task<UserEventModel> Update(UserEventModel userEventModel)
        {
            _context.Entry(userEventModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userEventModel;
        }

    }
}