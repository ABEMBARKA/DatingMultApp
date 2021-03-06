﻿namespace DatingApp.Api.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class DatingRepository:IDatingRepository
    {
        private readonly DataContext _context;

        public DatingRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async  Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users./*Include(p => p.Photos).*/ToListAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users./*Include(p => p.Photos).*/FirstOrDefaultAsync(u => u.Id == id);
        }

//        public async Task<Photo> GetPhoto(int id)
//        {
//            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
//            return photo;
//        }
//
//        public  async Task<Photo> GetMainPhotoForUser(int userId)
//        {
//            return await _context.Photos.Where(u => u.UserId == userId).FirstAsync(p => p.IsMain);
//        }
    }
}