﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public interface IFeedbackRepository
    {
        void AddFeadback(Feedback feedback);
    }
}
