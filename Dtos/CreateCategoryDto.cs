﻿namespace FullStackCI.Dtos
{
    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsBestSeller { get; internal set; }

    }
}
