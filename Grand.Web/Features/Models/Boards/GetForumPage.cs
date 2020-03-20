﻿using Grand.Core.Domain.Customers;
using Grand.Core.Domain.Forums;
using Grand.Web.Models.Boards;
using MediatR;

namespace Grand.Web.Features.Models.Boards
{
    public class GetForumPage : IRequest<ForumPageModel>
    {
        public Customer Customer { get; set; }
        public Forum Forum { get; set; }
        public int PageNumber { get; set; }
    }
}
