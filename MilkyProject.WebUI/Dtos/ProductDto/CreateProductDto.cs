﻿namespace MilkyProject.WebUI.Dtos.ProductDto
{
    public class CreateProductDto
    {

       
        public string productName { get; set; }
        public decimal oldPrice { get; set; }
        public decimal newPrice { get; set; }
        public string productImageUrl { get; set; }
        public bool status { get; set; }

    }
}
