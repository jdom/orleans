using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Orleans.CodeGeneration;

namespace Orleans.Core
{
    /// <summary>
    /// The collection of grain references types in an Orleans application. The <see cref="GrainReferenceFeature"/> can be populated
    /// using the <see cref="ApplicationPartManager"/>.
    /// </summary>
    public class GrainReferenceFeature
    {
        /// <summary>
        /// Gets a map from grain to grain reference types in an Orleans application.
        /// </summary>
        public IDictionary<Type, TypeInfo> GrainToReferenceMap { get; } = new Dictionary<Type, TypeInfo>();
    }

    /// <summary>
    /// Discovers grain references from a list of <see cref="ApplicationPart"/> instances.
    /// </summary>
    public class GrainRereferenceFeatureProvider : IApplicationFeatureProvider<GrainReferenceFeature>
    {
        /// <inheritdoc />
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, GrainReferenceFeature feature)
        {
            foreach (var part in parts.OfType<IApplicationPartTypeProvider>())
            {
                foreach (var type in part.Types)
                {
                    var grainReferenceAttr = type.GetCustomAttribute<GrainReferenceAttribute>(false);
                    if (grainReferenceAttr != null && !feature.GrainToReferenceMap.ContainsKey(grainReferenceAttr.TargetType))
                    {
                        feature.GrainToReferenceMap.Add(grainReferenceAttr.TargetType, type);
                    }
                }
            }
        }
    }
}
