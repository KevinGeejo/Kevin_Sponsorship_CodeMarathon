using SponsorshipApp.Models;

namespace SponsorshipApp.DAO
{
    public interface ISponsorDao
    {
        Task<List<SponsorPaymentDetails>> GetSponsorPaymentDetails();
        Task<List<MatchPaymentDetails>> GetMatchPaymentDetails();
        Task<List<SponsorMatchSummary>> GetSponsorMatchSummary(int year);
        Task<int> InsertPaymentDetails(PaymentDetails paymentDetails);
    }
}
