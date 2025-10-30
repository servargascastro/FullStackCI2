﻿using FullStackCI.Models;

namespace FullStackCI.Repositories
{
    public interface IAuthorCommandRepository
    {
        Author CreateAsync(Author category);
        Task UpdateAsync(Author category);
        Task DeleteAsync(int id);
    }
}
