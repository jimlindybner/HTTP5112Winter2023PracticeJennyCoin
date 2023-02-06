using System;
using System.Reflection;

namespace HTTP5112Winter2023PracticeJennyCoin.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}