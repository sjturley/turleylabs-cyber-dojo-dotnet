using System;

using NUnit.Framework;

using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalUtilities;

[TestFixture]
[UseReporter(typeof(QuietReporter))]
public class VideoStoreTest
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        Approvals.RegisterDefaultNamerCreation(() => new CyberDojoNamer());
    }
    
    [Test]
    public void RENAME_ME()
    {
        Approvals.Verify("Me");
    }
}
