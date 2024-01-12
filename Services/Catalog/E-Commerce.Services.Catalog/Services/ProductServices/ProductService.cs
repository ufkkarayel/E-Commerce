﻿using AutoMapper;
using E_Commerce.Services.Catalog.Dtos.ProductDtos;
using E_Commerce.Services.Catalog.Models;
using E_Commerce.Services.Catalog.Settings;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Services.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }
        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var values= _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(values);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(id);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(x=>true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);

        }

        public async Task<ResultProductDto> GetProductAsync(string id)
        {
            var values = await _productCollection.Find(x => x.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultProductDto>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
           var values = _mapper.Map<Product>(updateProductDto);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductID == updateProductDto.ProductID, values);
        }
    }
}
