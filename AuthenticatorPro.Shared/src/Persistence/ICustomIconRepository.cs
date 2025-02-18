// Copyright (C) 2021 jmh
// SPDX-License-Identifier: GPL-3.0-only

using AuthenticatorPro.Shared.Entity;

namespace AuthenticatorPro.Shared.Persistence
{
    public interface ICustomIconRepository : IAsyncRepository<CustomIcon, string>
    {
    }
}