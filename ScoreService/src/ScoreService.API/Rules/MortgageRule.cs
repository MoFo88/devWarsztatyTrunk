namespace ScoreService.API
{
    public class MortgageRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return !applicantRequest.Mortgage;
        }
    }
}
