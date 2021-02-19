﻿//---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
//----------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using OtripleS.Web.Api.Models.ExamAttachments;

namespace OtripleS.Web.Api.Services.ExamAttachments
{
    public interface IExamAttachmentService
    {
        ValueTask<ExamAttachment> AddExamAttachmentAsync(ExamAttachment examAttachment);
        IQueryable<ExamAttachment> RetrieveAllExamAttachments();
    }
}