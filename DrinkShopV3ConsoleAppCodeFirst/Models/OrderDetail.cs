﻿/***************************************************************
* Name        : OrderDetail class - DrinkShop3ConsoleAppCodeFirst 
*   project
* Author      : Elizabeth McCurdy
* Created     : 04/26/2024
***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShopV3ConsoleAppCodeFirst.Models
{
    public class OrderDetail
    {
        // Fields/attributes
        // Primary key - OrderDetailId
        private int _orderDetailId;
        private int _orderId;
        private int _drinkId;
        //?? private int _customerId;

        // Constructor(s) ?? None of the tutorials actually appeared to show 
        // Model class constructors?? or private attributes/fields
        // Default constructor
        public OrderDetail()
        {
        }
        // Parameterized Constructor(s)
        public OrderDetail(int orderDetailId, int orderId, int drinkId)
        {
            OrderDetailId = orderDetailId;
            OrderId = orderId;
            DrinkId = drinkId;
        }

        // Properties
        // If using Entity Framework do not need to specify [Key] as 
        // the EF assigns Properties named w/ 'ClassnameId' syntax as the
        // Class's Primary Key automatically. 
        //[Key]
        public int OrderDetailId { get => _orderDetailId; set => _orderDetailId = value; }
        // below 2 represent FK relationships
        public int OrderId { get => _orderId; set => _orderId = value; }
        public int DrinkId { get => _drinkId; set => _drinkId = value; }
        //??public int CustomerId { get => _customerId; set => _customerId = value; }

        // Navigation Properties:
        // OrderId property is a foreign key w/ the corresponding 'navigation property' of Order.
        // Navigation property for Order 
        public virtual Order Order { get; set; } = null!;
        // DrinkId property is a foreign key w/ the corresponding 'navigation property' of Drink.
        // Navigation property for Drink
        public virtual Drink Drink { get; set; } = null!;
        // ??public virtual Customer Customer { get; set; } = null!;

        // Methods

        public override string? ToString()
        {
            //return base.ToString();
            return $"Order Detail Id : {OrderDetailId}; Order Id : {OrderId}; Drink Id : {DrinkId}";
        }

    }
}
