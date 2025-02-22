﻿using Content.Shared.Eye.Blinding;
using Robust.Client.Graphics;

namespace Content.Client.Sun;

public sealed class SunSystem : EntitySystem
{
    [Dependency] private readonly ILightManager _lightManager = default!;

    public override void Initialize()
    {
        base.Initialize();

        // The sun is bright. I don't like it. It's cool and all but I don't like how we have a massive ball of pure agonizing fire in the sky.
        _lightManager.AmbientLightColor = Color.Gray;
    }
}
