﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ECommerceApi.Application.Features.Products.Command.CreateProduct;
using ECommerceApi.Application.Features.Products.Command.DeleteProduct;
using ECommerceApi.Application.Features.Products.Command.UpdateProduct;
using ECommerceApi.Application.Features.Products.Queries.GetAllProducts;

namespace ECommerceApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        //eğer route kısında /action yazmazsam burada httpget te
        //[HttpGet "GetAllProducts"] şekilinde routue u vermem gerekirdi
        //şimdi ise direkt olarak action ın adını kendisi alıcak
        //alttaki fonksiyon bakarsan action türünde görürsün

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());

            return Ok(response);

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();

        }
    }
}
