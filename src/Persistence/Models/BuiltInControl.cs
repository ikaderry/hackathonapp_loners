// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using Microsoft.PowerPlatform.PowerApps.Persistence.Templates;

namespace Microsoft.PowerPlatform.PowerApps.Persistence.Models;

public record BuiltInControl : Control
{
    public BuiltInControl()
    {
    }

    [SetsRequiredMembers]
    public BuiltInControl(string name, ControlTemplate controlTemplate) : base(name, controlTemplate)
    {
    }
}
