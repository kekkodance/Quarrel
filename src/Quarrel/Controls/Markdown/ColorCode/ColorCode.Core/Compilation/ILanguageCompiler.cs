// Copyright (c) Microsoft Corporation.  All rights reserved.
// Copyright (c) Quarrel. All rights reserved.

namespace Quarrel.Controls.Markdown.ColorCode.ColorCode.Core.Compilation
{
    public interface ILanguageCompiler
    {
        CompiledLanguage Compile(ILanguage language);
    }
}