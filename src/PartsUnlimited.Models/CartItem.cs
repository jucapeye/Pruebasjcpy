// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;//moto58888
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
   //hellojc79888
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
//hello8
        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}