using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvaMeetings.Web.Data;
using System;
using InvaMeetings.Web.Model;

namespace InvaMeetings.Web.Controllers
{
    public interface UserService
    {
        Task<List<UserModel>> Get();
        Task<UserModel> Get(string id);
        Task<UserModel> Update(UserModel userModel);
        Task<UserModel> Add(UserModel userModel);
    }


    public class UserServices : UserService
    {
        private readonly DatabaseContext _context;

        public UserServices(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<UserModel>> Get()
        {
            return await _context.userList.ToListAsync();
        }

        public async Task<UserModel> Get(string id)
        {
            Console.WriteLine("Trying to fetch userModel with id " + id);

            try
            {
                var userModel = await _context.userList.FindAsync(id);
                return userModel;
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Fetch failed");
                return null;
            }
        }


        public async Task<UserModel> Add(UserModel userModel)
        {
            _context.userList.Add(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }

        public async Task<UserModel> Update(UserModel userModel)
        {
            _context.Entry(userModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userModel;
        }
    }
}
