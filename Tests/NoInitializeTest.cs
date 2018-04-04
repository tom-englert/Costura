﻿using Fody;
using Xunit;

public class NoInitializeTest
{
    [Fact]
    public void FailsToWeave()
    {
        Assert.Throws<WeavingException>(() =>
                WeavingHelper.CreateIsolatedAssemblyCopy("AssemblyWithoutInitialize",
                "<Costura LoadAtModuleInit='false' />",
                new[] { "AssemblyToReference.dll", "AssemblyToReferencePreEmbedded.dll", "ExeToReference.exe" },
                    "NoInitialize"));
    }
}