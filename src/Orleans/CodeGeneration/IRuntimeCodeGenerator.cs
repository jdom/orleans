using System.Collections.Generic;

namespace Orleans.CodeGeneration
{
    using System.Reflection;

    /// <summary>
    /// Methods for generating code at runtime.
    /// </summary>
    internal interface IRuntimeCodeGenerator
    {
        /// <summary>
        /// Ensures that code generation has been run for the provided assembly.
        /// </summary>
        /// <param name="input">The assembly to generate code for.</param>
        /// <param name="loadedAssembly">The loaded instance of the generated assembly if the result is true</param>
        bool TryGenerateAndLoadForAssembly(Assembly input, out Assembly loadedAssembly);

        /// <summary>
        /// Generates and loads code for the specified inputs.
        /// </summary>
        /// <param name="inputs">The assemblies to generate code for.</param>
        /// <param name="loadedAssemblies">The loaded instances of the generated assemblies if the result is true</param>
        bool TryGenerateAndLoadForAssemblies(ICollection<Assembly> inputs, out ICollection<Assembly> loadedAssemblies);
    }
}
