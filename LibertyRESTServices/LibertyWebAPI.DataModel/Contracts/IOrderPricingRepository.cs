﻿using LibertyWebAPI.BusinessEntities;
using LibertyWebAPI.DTO.Common;
using LibertyWebAPI.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibertyWebAPI.DataModel.Contracts
{
    public interface IOrderPricingRepository
    {
        ErrorsDTO GetOrderPrice(OrderDTO orderRequest, int sessionId);
    }
}
