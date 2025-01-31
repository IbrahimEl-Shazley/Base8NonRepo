﻿using Microsoft.AspNetCore.Http;

namespace BaseProject.Services.Api.Implementation.General
{
    public class ApplicationService : UserContext
    {
        public ApplicationService(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        protected string Lang => APILang;

        protected string UserId => APIUserId;
    }
}
