using System;
using System.Collections.Generic;
using System.Reflection;
using Orleans.CodeGeneration;

namespace Orleans.Core
{
    /// <summary>
    /// The collection of grain references types in an Orleans application.
    /// </summary>
    public class GrainReferenceFeature
    {
        /// <summary>
        /// Gets a map from grain to grain reference types in an Orleans application.
        /// </summary>
        public IDictionary<Type, TypeInfo> GrainToReferenceMap { get; } = new Dictionary<Type, TypeInfo>();
    }

    /// <summary>
    /// Discovers grain references from a list of types.
    /// </summary>
    public class GrainReferenceFeatureProvider //: IApplicationFeatureProvider<GrainReferenceFeature>
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
        public void PopulateFeature(IEnumerable<TypeInfo> types, GrainReferenceFeature feature)
        {
            foreach (var type in types)
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
