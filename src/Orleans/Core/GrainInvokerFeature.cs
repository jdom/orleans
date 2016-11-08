using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Orleans.CodeGeneration;

namespace Orleans.Core
{
    /// <summary>
    /// The collection of grain invoker types in an Orleans application. The <see cref="GrainInvokerFeature"/> can be populated
    /// using the <see cref="ApplicationPartManager"/>.
    /// </summary>
    public class GrainInvokerFeature
    {
        /// <summary>
        /// Gets a map from grain to grain invoker types in an Orleans application.
        /// </summary>
        public IDictionary<Type, TypeInfo> GrainToInvokerMap { get; } = new Dictionary<Type, TypeInfo>();
    }

    /// <summary>
    /// Discovers grain invokers from a list of <see cref="ApplicationPart"/> instances.
    /// </summary>
    public class GrainInvokerFeatureProvider : IApplicationFeatureProvider<GrainInvokerFeature>
    {
        /// <inheritdoc />
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, GrainInvokerFeature feature)
        {
            foreach (var part in parts.OfType<IApplicationPartTypeProvider>())
            {
                foreach (var type in part.Types)
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
}
