﻿using JetBrains.Annotations;

namespace Unity.Tiny 
{
    [TinyCustomEditor(CoreGuids.Particles.EmitterInitialScale)]
    [UsedImplicitly]
    internal class EmitterInitialScaleEditor : ParticleComponentEditor
    {
        public EmitterInitialScaleEditor(TinyContext context)
            : base(context) { }

        public override bool Visit(ref UIVisitContext<TinyObject> context)
        {
            ShowParticleEmitterWarning(ref context);
            return base.Visit(ref context);
        }
    }
}
