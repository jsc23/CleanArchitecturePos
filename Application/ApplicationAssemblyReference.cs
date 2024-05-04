using System.Reflection;

namespace Application;
//this class will allow us to insert mediatR as a dependendy
public class ApplicationAssemblyReference
{
    internal static readonly Assembly Assembly = typeof(ApplicationAssemblyReference).Assembly;
}
