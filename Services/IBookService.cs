﻿using FullStackCI.Dtos;
using FullStackCI.Models;

namespace FullStackCI.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetAllBooksAsync();
        Task<BookDto?> GetBookByIdAsync(int id);
    }
}
