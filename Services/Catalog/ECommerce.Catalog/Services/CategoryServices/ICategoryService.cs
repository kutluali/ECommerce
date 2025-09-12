﻿using System;
using ECommerce.Catalog.Dtos.CatgoryDtos;

namespace ECommerce.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {

        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryDtoAsync(string id);
    }
}

