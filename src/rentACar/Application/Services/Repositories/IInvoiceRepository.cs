﻿using Application.Features.Invoices.Dtos;
using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IInvoiceRepository:IAsyncRespository<Invoice>
    {
        Task<IPaginate<InvoiceListDto>> GetListInvoices(int index = 0,
           int size = 10,
           CancellationToken cancellationToken = default);
    }
}
