// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

#if XENKO_GRAPHICS_API_NULL 

namespace Xenko.Graphics
{
    public partial class PipelineState
    {
        /// <summary>
        /// Initializes new instance of <see cref="PipelineState"/> for <param name="device"/>
        /// </summary>
        /// <param name="device">The graphics device.</param>
        /// <param name="pipelineStateDescription">The pipeline state description.</param>
        private PipelineState(GraphicsDevice device, PipelineStateDescription pipelineStateDescription) : base(device)
        {
            NullHelper.ToImplement();
        }
    }
}

#endif
