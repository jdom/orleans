using System.Collections.Generic;
using System.Reflection;

namespace Orleans.CodeGeneration
{

    /// <summary>
    /// Methods for generating code at runtime.
    /// </summary>
    internal interface IRuntimeCodeGenerator
    {
        /// <summary>
        /// Generates and loads code for the specified inputs.
        /// </summary>
        /// <param name="inputs">The assemblies to generate code for.</param>
        /// <param name="loadedAssemblies">The loaded instances of the generated assemblies if the result is true</param>
        bool TryGenerateAndLoadForAssemblies(ICollection<Assembly> inputs, out ICollection<Assembly> loadedAssemblies);
    }
}
