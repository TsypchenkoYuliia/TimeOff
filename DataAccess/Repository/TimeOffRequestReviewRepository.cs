﻿using DataAccess.Context;
using DataAccess.Repository.Interfaces;
using Domain.EF_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TimeOffRequestReviewRepository : BaseRepository<TimeOffRequestReview, int>
    {
        public TimeOffRequestReviewRepository(TimeOffTrackerContext context) : base(context) { }       
    }
}
