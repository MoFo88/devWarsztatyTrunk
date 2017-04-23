namespace ScoreService.API
{
    public class IncomeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return applicantRequest.Income >= 10000;
        }
    }
}
