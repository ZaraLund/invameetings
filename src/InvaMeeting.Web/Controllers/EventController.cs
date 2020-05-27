using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvaMeetings.Web.Data;
using System;
using System.Linq;
using InvaMeetings.Web.Model;
using Microsoft.Extensions.Logging;

namespace InvaMeetings.Web
{
    public interface EventController
    {
        Task<List<EventModel>> Get();
        Task<EventModel> Get(Guid id);
        Task<EventModel> Add(EventModel eventModel);
        Task<EventModel> Update(EventModel eventModel);
        Task<EventModel> Delete(Guid id);
    }
    public class EventControllers : EventController
    {
        private readonly DatabaseContext _context;

        public EventControllers(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<EventModel>> Get()
        {
            return await _context.eventList.ToListAsync();
        }

        public async Task<EventModel> Get(Guid id)
        {
            var eventModel = await _context.eventList.FindAsync(id);
            return eventModel;
        }

        public async Task<EventModel> Add(EventModel eventModel)
        {
            _context.eventList.Add(eventModel);
            await _context.SaveChangesAsync();
            return eventModel;
        }

        public async Task<EventModel> Update(EventModel eventModel)
        {
            _context.Entry(eventModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return eventModel;
        }

        public async Task<EventModel> Delete(Guid id)
        {
            var eventModel = await _context.eventList.FindAsync(id);
            _context.eventList.Remove(eventModel);
            await _context.SaveChangesAsync();
            return eventModel;
        }



    }
}