using System;

namespace ScoreService.API
{
    public class CountryRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return !String.IsNullOrWhiteSpace(applicantRequest.Country) && applicantRequest.Country.Equals("Poland", StringComparison.OrdinalIgnoreCase);
        }
    }
}
