using System;
using System.Collections.Generic;
using System.Reflection;
using Orleans.CodeGeneration;

namespace Orleans.Runtime
{
    /// <summary>
    /// The collection of grain invoker types in an Orleans application.
    /// </summary>
    public class GrainInvokerFeature
    {
        /// <summary>
        /// Gets a map from grain to grain invoker types in an Orleans application.
        /// </summary>
        public IDictionary<Type, TypeInfo> GrainToInvokerMap { get; } = new Dictionary<Type, TypeInfo>();
    }

    /// <summary>
    /// Discovers grain invokers from a list of types.
    /// </summary>
    public class GrainInvokerFeatureProvider // : IApplicationFeatureProvider<GrainInvokerFeature>
    {
        ///// <inheritdoc />
        //public void PopulateFeature(IEnumerable<ApplicationPart> parts, GrainReferenceFeature feature)
        //{
        //    PopulateFeature(parts.OfType<IApplicationPartTypeProvider>().SelectMany(part => part.Types), feature);
        //}

        /// <summary>
        /// Updates the <paramref name="feature"/> instance.
        /// </summary>
        /// <param name="types">The list of types of the application</param>
        /// <param name="feature">The feature instance to populate.</param>
        public void PopulateFeature(IEnumerable<TypeInfo> types, GrainInvokerFeature feature)
        {
            foreach (var type in types)
            {
                var grainInvokerAttr = type.GetCustomAttribute<MethodInvokerAttribute>(false);
                if (grainInvokerAttr != null && !feature.GrainToInvokerMap.ContainsKey(grainInvokerAttr.TargetType))
                {
                    feature.GrainToInvokerMap.Add(grainInvokerAttr.TargetType, type);
                }
            }
        }
    }
}
