﻿using AutoMapper;
using SolidProducts.DTOs;
using SolidProducts.Entities;

namespace SolidProducts.Controllers;

public class ProductControllerMapper : Profile
{
    public ProductControllerMapper()
    {
        CreateMap<ProductRequestDto, Product>();

        CreateMap<Product, ProductResponseDto>()
            .ForMember(dest => dest.ProductGroupName, opt => opt.MapFrom(src => src.ProductGroup.Name))
            .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.Manufacturer.Name))
            .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.Name));
    }
}
