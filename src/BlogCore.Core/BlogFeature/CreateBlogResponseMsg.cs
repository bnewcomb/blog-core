﻿using FluentValidation.Results;

namespace BlogCore.Core.BlogFeature
{
    public class CreateBlogResponseMsg : IMesssage
    {
        public CreateBlogResponseMsg(long? blogId, ValidationResult validationResult)
        {
            BlogId = blogId;
            ValidationResult = validationResult;
        }

        public ValidationResult ValidationResult { get; }
        public long? BlogId { get; private set; }
    }
}