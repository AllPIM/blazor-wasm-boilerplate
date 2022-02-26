﻿namespace FSH.BlazorWebAssembly.Client.Infrastructure.Common;

public record LanguageCode(string Code, string DisplayName, bool IsRTL = false);

public static class LocalizationConstants
{
    public static readonly LanguageCode[] SupportedLanguages =
    {
        new("en-US", "English"),
        new("zh-CN", "Simple Chinese"),
        new("zh-TW", "Traditional Chinese")
    };
}