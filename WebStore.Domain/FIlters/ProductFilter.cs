﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.FIlters
{
    /// <summary>
    /// Класс для фильтрации товаров
    /// </summary>
    public class ProductFilter
    {
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
    }

}
