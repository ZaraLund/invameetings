using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvaMeetings.Web.Data;
using InvaMeetings.Web.Model;
using System.Linq;
using System.Data;

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
            if (_context.userEventModelList.Where(e => e.EventId == userEventModel.EventId && e.UserId == userEventModel.UserId).Any())
            {
                _context.userEventModelList.Add(userEventModel);
                await _context.SaveChangesAsync();
                return userEventModel;
            }
            else
            {
                Console.WriteLine("Exist");
                return null;
            }
        }
        /*
        from em in _context.userEventModelList
              join u in _context.userList
                  on em.UserId equals u.UserId
              where em.EventId == id
              select new ParticipantModel
              */
        public async Task<UserEventModel> Update(UserEventModel userEventModel)
        {
            _context.Entry(userEventModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userEventModel;
        }

    }
}