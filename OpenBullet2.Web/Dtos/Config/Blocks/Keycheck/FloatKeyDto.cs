﻿using OpenBullet2.Web.Attributes;
using RuriLib.Models.Blocks.Custom.Keycheck;
using RuriLib.Models.Conditions.Comparisons;

namespace OpenBullet2.Web.Dtos.Config.Blocks.Keycheck;

/// <summary>
/// A floating point key of the keychain.
/// </summary>
[PolyType("floatKey")]
[MapsFrom(typeof(FloatKey))]
public class FloatKeyDto : KeyDto
{
    /// <summary>
    /// The comparison condition.
    /// </summary>
    public NumComparison Comparison { get; set; }
}
