using NUnit.Framework;
using System;

using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalUtilities;

[TestFixture]
[UseReporter(typeof(QuietReporter))]
public class GildedRoseTest
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        Approvals.RegisterDefaultNamerCreation(() => new CyberDojoNamer());
    }
    
    [Test]
    public void ApproveGildedRose()
    {
    }
}
