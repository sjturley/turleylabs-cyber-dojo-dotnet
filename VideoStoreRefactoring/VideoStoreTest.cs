using System;

using Xunit;
using ApprovalTests;
using ApprovalTests.Reporters;

[UseReporter(typeof(QuietReporter))]
public class VideoStoreTest
{
    [Fact]
    public void RENAME_ME()
    {
        Approvals.Verify("Me");
    }
}
