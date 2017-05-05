using Orleans.Core;
using System;

namespace Orleans.Runtime
{
    public class GrainActivationContext
    {
        private readonly GrainTypeData grainTypeData;

        internal GrainActivationContext(GrainTypeData grainTypeData, IGrainIdentity grainIdentity)
        {
            this.grainTypeData = grainTypeData;
            this.GrainIdentity = grainIdentity;
        }

        public Type GrainType => this.grainTypeData.Type;

        public IGrainIdentity GrainIdentity { get; }

        /// <summary>
        /// Gets or sets the <see cref="IServiceProvider"/> that provides access to the grain's service container.
        /// </summary>
        public IServiceProvider GrainServices { get; set; }
    }
}