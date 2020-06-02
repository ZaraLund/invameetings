using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvaMeetings.Web.Data;
using InvaMeetings.Web.Model;
using System.Linq;

namespace InvaMeetings.Web.Controllers
{
    public interface ParticipantService
    {
        Task<List<ParticipantModel>> GetParticipantBy(Guid id);
    }

    public class ParticipantServices : ParticipantService
    {
        private readonly DatabaseContext _context;

        public ParticipantServices(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<ParticipantModel>> GetParticipantBy(Guid id)
        {
            List<ParticipantModel> result = await (
                from em in _context.userEventModelList
                join u in _context.userList
                    on em.UserId equals u.UserId
                where em.EventId == id
                select new ParticipantModel
                {
                    Name = u.Name,
                    EventId = new Guid(em.EventId.ToString()),
                }
            ).ToListAsync();

            return result;
        }

    }
}
