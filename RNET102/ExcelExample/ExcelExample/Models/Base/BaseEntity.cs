﻿namespace ExcelExample.Models.Base
{
    internal class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
