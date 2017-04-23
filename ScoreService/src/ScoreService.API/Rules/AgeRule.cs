using System;

namespace ScoreService.API
{
    public class AgeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return applicantRequest.Age >= 21;
        }
    }
}
