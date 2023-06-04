using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Moneybird.Net.Endpoints.Abstractions.Common;
using Moneybird.Net.Endpoints.ExternalSalesInvoices.Models;
using Moneybird.Net.Entities.ExternalSalesInvoices;

namespace Moneybird.Net.Endpoints.Abstractions
{
    public interface IExternalSalesInvoiceEndpoint :
        IReadEndpoint<ExternalSalesInvoice>,
        IGetEndpoint<ExternalSalesInvoice>
    {
        /// <summary>
        /// Get list of all the external sales invoices with filter options.
        /// </summary>
        /// <param name="administrationId">The administration id.</param>
        /// <param name="accessToken">The access token.</param>
        /// <param name="options">The filter options.</param>
        /// <returns></returns>
        Task<List<ExternalSalesInvoice>> GetSalesInvoicesAsync(string administrationId, string accessToken, ExternalSalesInvoiceFilterOptions options);

        /// <summary>
        /// Create a new external sale invoice.
        /// </summary>
        /// <param name="administrationId">The administration id.</param>
        /// <param name="options">The external sale invoice to create.</param>
        /// <param name="accessToken">The access token.</param>
        Task<ExternalSalesInvoice> CreateSalesInvoiceAsync(string administrationId, ExternalSalesInvoiceCreateOptions options, string accessToken);

        /// <summary>
        /// Add an attachment to an external sale invoice.
        /// </summary>
        /// <param name="administrationId">The administration id.</param>
        /// <param name="id">The external sale invoice id.</param>
        /// <param name="body">The file to attach.</param>
        /// <param name="accessToken">The access token.</param>
        /// <param name="fileName">The file name. Defaults to "invoice.pdf".</param>
        Task AddAttachmentAsync(string administrationId, string id, Stream body, string accessToken, string fileName = "invoice.pdf");
    }
}
