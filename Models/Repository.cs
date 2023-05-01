using System.Collections.Generic;

namespace SurveyApp.Models
{
  public static class Repository
  {
    private static List<SurveyResponse> responses = new List<SurveyResponse>();

    public static IEnumerable<SurveyResponse> SurveyResponses { get { return responses; } }

    public static void AddResponse(SurveyResponse response)
    {
      responses.Add(response);
    }
  }
}

