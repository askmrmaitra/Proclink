using System;
using System.Collections.Generic;
using System.Text;
using Feedback;
namespace FeedbackM
{
    class FeedbackManager
    {
        Predicate<int> isPositive = rating => rating >= 4;
        public bool IsPositive(CustomerFeedback feedback)
        {
            return isPositive(feedback.Rating);
        }
    }
}
